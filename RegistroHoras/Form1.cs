using Microsoft.Data.Sqlite;
using System.Data;

namespace RegistroHoras
{
    public partial class Form1 : Form
    {
        private SqliteConnection connection;
        TimeSpan totalHorasMinutosSomadas = TimeSpan.Zero;
        public Form1()
        {
            InitializeComponent();
            InicializarBD();
            CarregarDadosRegistroHorario(DateTime.Now);
        }


        public void InicializarBD()
        {
            // Obtenha o diretório base do aplicativo (onde o executável está localizado)
            string diretorioBase = AppDomain.CurrentDomain.BaseDirectory;

            // Adicione as pastas ao caminho do banco de dados
            string nomeDoArquivo = "MeuBancoDeDados.db";
            string caminhoDoBancoDeDados = Path.Combine(diretorioBase, nomeDoArquivo);

            string connectionString = $"Data Source={caminhoDoBancoDeDados}";

            connection = new SqliteConnection(connectionString);

            connection.Open();

            // Crie a tabela se ela ainda não existirx'
            using (var cmd = new SqliteCommand
                ("CREATE TABLE IF NOT EXISTS RegistroHorario " +
                "(ID INTEGER PRIMARY KEY, horarioInicio TEXT," +
                " horarioFim TEXT, demandaRealizada TEXT," +
                "totalHoras DATETIME)", connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        private void Salvar_Click(object sender, EventArgs e)
        {

            var horaInicio = horarioInicio.Value;
            var horaFim = horarioFim.Value;

            TimeSpan totalHoras = horaFim - horaInicio;


            string insertQuery = "INSERT INTO RegistroHorario" +
                "(demandaRealizada, horarioInicio, horarioFim, totalHoras) " +
                "VALUES " +
                "(@demandaRealizada, @horarioInicio, @horarioFim, @totalHoras)";

            using (var cmd = new SqliteCommand(insertQuery, connection))
            {
                cmd.Parameters.AddWithValue("@horarioInicio", horaInicio);
                cmd.Parameters.AddWithValue("@horarioFim", horaFim);
                cmd.Parameters.AddWithValue("@totalHoras", totalHoras);
                cmd.Parameters.AddWithValue("@demandaRealizada", textBoxDemanda.Text);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Dados salvos com sucesso!");

            //Trazer listagem na tela
            listarButton_Click(new object { }, new EventArgs());
        }

        private void CarregarDadosRegistroHorario(DateTime dataDePesquisa)
        {
            
            var anoMesDia = dataDePesquisa.ToString("yyyy-MM-dd");
            TimeSpan totalHoras = TimeSpan.Zero;  // Variável para armazenar o total de horas

            using (var cmd = new SqliteCommand("SELECT * FROM RegistroHorario where Date(horarioInicio) = @horarioInicio", connection))
            {
                cmd.Parameters.AddWithValue("@horarioInicio", anoMesDia);

                using (SqliteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Exiba os dados em uma DataGridView, ListBox, ou qualquer outro controle de exibição que você preferir.
                        // Por exemplo, se você tem uma DataGridView chamada dataGridView1:
                        dataGridView1.Rows.Add(
                            reader["demandaRealizada"], reader["horarioInicio"], reader["horarioFim"], reader["totalHoras"]);


                        //FUNCAO SOMAR TODOS OS TOTAIS DE HORA DAQUELE DIA
                        totalHoras = SomarTotalHoras(reader["totalHoras"]);

                    }
                }
            }

            totalHorasDiaLabel.Text = totalHoras.ToString();
        }

        public TimeSpan SomarTotalHoras(object totalHorasObject)
        {
            var totalHorasDateTime = Convert.ToDateTime(totalHorasObject);
            //transformar em horas e minutos
            totalHorasMinutosSomadas += totalHorasDateTime.TimeOfDay;

            return totalHorasMinutosSomadas;
        }

        private void VerificarTotaisHorario(SqliteDataReader reader)
        {
            var dataDia = Convert.ToDateTime(reader["horarioInicio"]);
            

        }

        private void totalHorasDia_Click(object sender, EventArgs e)
        {

        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            //Zerar a contagem das horas e iniciar novamente
            totalHorasMinutosSomadas = TimeSpan.Zero;

            LimparFiltrosDataGridView();
            
            CarregarDadosRegistroHorario(dataListagemDatePicker.Value);
        }

        private void LimparFiltrosDataGridView()
        {
            dataGridView1.Rows.Clear();
        }


        //Funcao para deletar uma linha selecionado
        private void DeletarButton_Click(object sender, EventArgs e)
        {
            // Obtenha a linha da célula atualmente selecionada
            int linhaSelecionada = dataGridView1.CurrentCell.RowIndex;


            var colunaHorarioInicio = dataGridView1.Rows[linhaSelecionada].Cells["horaInicioTextBoxColumn"].Value;
            var colunaHorarioFim = dataGridView1.Rows[linhaSelecionada].Cells["horaFimTextBoxColumn"].Value;


            using (var cmd = new SqliteCommand("" +
                 "DELETE FROM RegistroHorario " +
                 "WHERE horarioInicio = @horarioInicio " +
                 "AND horarioFim = @horarioFim", connection))
            {
                cmd.Parameters.AddWithValue("@horarioInicio", colunaHorarioInicio);
                cmd.Parameters.AddWithValue("@horarioFim", colunaHorarioFim);
                cmd.ExecuteNonQuery();
                //Buscar novamente a listagem
            }

            object obj = new object { };
            //Trazer novamente a listagem
            listarButton_Click(new object { }, new EventArgs());

        }
    }
}
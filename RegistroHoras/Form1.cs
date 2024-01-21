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
            string dataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            string databasePath = "C:\\Users\\mateu\\OneDrive\\Área de Trabalho\\Utilitarios\\projetos\\RegistroHorarioBd\\MeuBancoDeDados.db";
            string connectionString = $"Data Source={databasePath}";

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
            
            //carregar informações na tela
            CarregarDadosRegistroHorario(DateTime.Now);
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
            LimparFiltrosDataGridView(); 
            CarregarDadosRegistroHorario(dataListagemDatePicker.Value);
            //dataListagemDatePicker
        }

        private void LimparFiltrosDataGridView()
        {
            dataGridView1.Rows.Clear();
        }
    }
}
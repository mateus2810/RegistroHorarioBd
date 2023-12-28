using Microsoft.Data.Sqlite;

namespace RegistroHoras
{
    public partial class Form1 : Form
    {
        private SqliteConnection connection;
        public Form1()
        {
            InitializeComponent();
            InicializarBD();
        }


        public void InicializarBD()
        {
            string dataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            string databasePath = "C:\\Users\\mateu\\OneDrive\\�rea de Trabalho\\Utilitarios\\projetos\\RegistroHorarioBd\\MeuBancoDeDados.db";
            string connectionString = $"Data Source={databasePath}";

            connection = new SqliteConnection(connectionString);

            connection.Open();

            // Crie a tabela se ela ainda n�o existirx'
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
        }
    }
}
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Text;

namespace MySQLConexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            String host = txthost.Text;
            String user = txtUsuario.Text;
            String password = txtContrasena.Text;
            String puerto = txtPuerto.Text;
            String database = txtBasededatos.Text;

            string connectionString = BuildConnectionString(host, user, password, puerto, database);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("Select * from CatPersonal", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvdatos.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error" + ex.Message);

                }
            }
        }
        private string BuildConnectionString(string host, string user, string password, string port, string database)
        {
            return $"SERVER={host};PORT={port};DATABASE={database};USER ID={user};PASSWORD={password};";

        }

    }
}
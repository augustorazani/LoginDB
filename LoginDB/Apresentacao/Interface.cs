using LoginDB.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginDB.Apresentacao
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Interface_Load(object sender, EventArgs e) //exibe os dados do banco na tela
        {
            String stringConexao = ConfigurationManager.ConnectionStrings["minhaconexao"].ConnectionString; //utiliza a string de conexao configurada no App.config
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("ObtemDadosUsuarios", conn)) //roda a stored procedure ObtemDadosUsuarios
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader(); //executa o comando contido na sp
                    dt.Load(dr); //atribui os dados encontrados na variárvel dt
                }

            }
            dgvUsuarios.DataSource = dt; //mostra os dados da variaver dt no data grid view da interface
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testes_06_07_08_09
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            SqlConnection conexao = new SqlConnection("Data Source=LAPTOP-C06OBA9V\\SQLSERVER2022;Initial Catalog=Aluno;Integrated Security=True;");
            conexao.Open();
            
            
        }   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mostra_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-C06OBA9V\\SQLSERVER2022;Initial Catalog=Aluno;Integrated Security=True;";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();

                string sqlconsulta = "SELECT *, " +
                          "([nota 1º semestre] + [nota 2º semestre]) / 2 AS media, " +
                          "CASE WHEN [nota 1º semestre] >= 6.5 THEN 'aprovado' ELSE 'reprovado' END AS status " +
                          "FROM Alunos";

                using (SqlCommand command = new SqlCommand(sqlconsulta, conexao))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void volta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

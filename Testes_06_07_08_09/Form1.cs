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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            
        
        form2.Show();

        }

        private void envia_Click(object sender, EventArgs e)
        {
            String nome = nomeAluno.Text;
            float nota1 = float.Parse(nota1semestre.Text);
            float nota2 = float.Parse(nota2semestre.Text);
            int Ano = int.Parse(ano.Text);

            //criar a database no sql server manager

            //LAPTOP - C06OBA9V\SQLSERVER2022
            //database Aluno

            //criar a tabela alunos dentro da DB Aluno


            using (SqlConnection conexao = new SqlConnection("Data Source=LAPTOP-C06OBA9V\\SQLSERVER2022;Initial Catalog=Aluno;Integrated Security=True;"))
            {
                conexao.Open();

                string sqlconsulta = "INSERT INTO Alunos (nome , [nota 1º semestre], [nota 2º semestre], Ano) VALUES (@nome, @nota1, @nota2, @Ano)";

                using (SqlCommand command = new SqlCommand(sqlconsulta, conexao))
                {
                    
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@nota1", nota1);
                    command.Parameters.AddWithValue("@nota2", nota2);
                    command.Parameters.AddWithValue("@Ano", Ano);

                   
                    command.ExecuteNonQuery();

                }
            }

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

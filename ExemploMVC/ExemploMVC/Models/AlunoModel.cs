using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploMVC.Models
{
    public class AlunoModel
    {
        public int id { get; set; }
        public String nome { get; set; }
        public String ra { get; set; }
        public String cpf { get; set; }
        public int idade { get; set; }

        readonly String connectionString = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=AVA33;Integrated Security=True";
        public void Salvar() {

            using ( SqlConnection sqlCon = new SqlConnection(connectionString) )
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("INSERT INTO aluno VALUES (@nome, @ra, @cpf, @idade)", sqlCon);

                sqlCmd.Parameters.AddWithValue("@nome", nome);
                sqlCmd.Parameters.AddWithValue("@ra", ra);
                sqlCmd.Parameters.AddWithValue("@cpf", cpf);
                sqlCmd.Parameters.AddWithValue("@idade", idade);

                sqlCmd.ExecuteNonQuery();
            }

        }
    }
}

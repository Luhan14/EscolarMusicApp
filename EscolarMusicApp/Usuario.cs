using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using EscolarMusicApp;
namespace ConsoleApp5
{
    public class Usuario
    {
        public int Id { get; set; } // Propriedades
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Situacao { get; set; }

        public Usuario()
        {
          
        }

        public Usuario(int id, string nome, string email, string senha, string situacao)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Situacao = situacao;
        }

        public Usuario(string nome, string email, string senha, string situacao)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Situacao = Situacao;
        }

        public Usuario(string nome, string email, string senha)
        {
            Nome = Nome;
            Email = email;
            Senha = senha;
        }

        public Usuario(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

        public bool EfetuarLogin(Usuario usuario)
        {
            bool valido = false;
            var cmd = Banco.AbriConexao();
            cmd.CommandText = "select * from tb_usuario where senha_usuario = md5(@senha) " + "and email_usuario = @email;";
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = usuario.Senha;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = usuario.Email;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Situacao = dr.GetString(4);
                valido = true;
            }

            return valido;
        }
    }
}


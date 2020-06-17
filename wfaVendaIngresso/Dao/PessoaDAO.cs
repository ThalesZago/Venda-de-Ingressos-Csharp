using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using wfaVendaIngresso.Classes;
using System.Data;
namespace wfaVendaIngresso.Dao
{
    public class PessoaDAO : Conexao
    {

        public void delete(Pessoa pessoa)
        {
            try
            {

                openConnection();
                var comando = conexao.CreateCommand();
                comando = new MySqlCommand("DELETE from pessoa WHERE cpf = @cpf", conexao);
                comando.Parameters.AddWithValue("@cpf", pessoa.cpf);
                

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                closeConnection();
            }
        }

        public void insert(Pessoa pessoa)
        {
            
            try
            {
               
                openConnection();
                var comando = conexao.CreateCommand();
                comando = new MySqlCommand("INSERT INTO Pessoa(cpf, tipo, dataNascimento, nome, email, telefone, endereco, bairro, cep, cidade, estado, username, passw, isAdmin) VALUES (@cpf, @tipo, @dataNasc, @nome, @email, @tel, @end, @bairro, @cep, @cidade, @estado, @username, @passw, @isAdmin)", conexao);
                comando.Parameters.AddWithValue("@cpf", pessoa.cpf);
                comando.Parameters.AddWithValue("@tipo", pessoa.tipo);
                comando.Parameters.AddWithValue("@dataNasc", pessoa.dataNascimento);
                comando.Parameters.AddWithValue("@nome", pessoa.nome);
                comando.Parameters.AddWithValue("@email", pessoa.email);
                comando.Parameters.AddWithValue("@tel", pessoa.telefone);
                comando.Parameters.AddWithValue("@end", pessoa.endereco);
                comando.Parameters.AddWithValue("@bairro", pessoa.bairro);
                comando.Parameters.AddWithValue("@cep", pessoa.cep);
                comando.Parameters.AddWithValue("@cidade", pessoa.cidade);
                comando.Parameters.AddWithValue("@estado", pessoa.estado);
                comando.Parameters.AddWithValue("@username", pessoa.username);
                comando.Parameters.AddWithValue("@passw", pessoa.password);
                comando.Parameters.AddWithValue("@isAdmin", pessoa.isAdmin);
                comando.Parameters.AddWithValue("@imgUser", pessoa.imgUser);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                closeConnection();
            }
        }
        public void update(Pessoa pessoa)
        {
            try
            {
                
                openConnection();
                var comando = conexao.CreateCommand();
                comando = new MySqlCommand("UPDATE Pessoa SET cpf = @cpf, tipo = @tipo, dataNascimento = @dataNasc, nome = @nome, email = @email, telefone = @tel, endereco = @end, bairro = @bairro, cep = @cep, cidade = @cidade, estado = @estado, imgUser = @imgUser WHERE cpf = @cpf", conexao);
                comando.Parameters.AddWithValue("@cpf", pessoa.cpf);
                comando.Parameters.AddWithValue("@tipo", pessoa.tipo);
                comando.Parameters.AddWithValue("@dataNasc", pessoa.dataNascimento);
                comando.Parameters.AddWithValue("@nome", pessoa.nome);
                comando.Parameters.AddWithValue("@email", pessoa.email);
                comando.Parameters.AddWithValue("@tel", pessoa.telefone);
                comando.Parameters.AddWithValue("@end", pessoa.endereco);
                comando.Parameters.AddWithValue("@bairro", pessoa.bairro);
                comando.Parameters.AddWithValue("@cep", pessoa.cep);
                comando.Parameters.AddWithValue("@cidade", pessoa.cidade);
                comando.Parameters.AddWithValue("@estado", pessoa.estado);
                comando.Parameters.AddWithValue("@imgUser", pessoa.imgUser);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                closeConnection();
            }
        }

        public List<Pessoa> getPessoas(string username, string password)
        {
            this.openConnection();

            var command = conexao.CreateCommand();
            MySqlCommand query = new MySqlCommand("select * from pessoa where username = '" + username + "' and passw = '" + password + "';", conexao);

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            da.Fill(dt);

            this.closeConnection();

            return dt.DataTableToList<Pessoa>();
        }
    }
}

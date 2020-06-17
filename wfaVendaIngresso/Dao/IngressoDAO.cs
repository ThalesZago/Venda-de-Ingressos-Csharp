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
    public class IngressoDAO : Conexao
    {

        public void delete(Ingresso ingresso)
        {
            try
            {

                openConnection();
                var comando = conexao.CreateCommand();
                comando = new MySqlCommand("DELETE from ingresso WHERE id = @id", conexao);
                comando.Parameters.AddWithValue("@id", ingresso.id);
                

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

        public void insert(Ingresso ingresso)
        {
            
            try
            {
               
                openConnection();
                var comando = conexao.CreateCommand();
                comando = new MySqlCommand("INSERT INTO Ingresso(valor, formaPagamento, fk_Pessoa_cpf, fk_Evento_id) VALUES (@valor, @formaPagamento, @fk_Pessoa_cpf, @fk_Evento_id)", conexao);
                comando.Parameters.AddWithValue("@valor", ingresso.valor);
                comando.Parameters.AddWithValue("@formaPagamento", ingresso.formaPagamento);
                comando.Parameters.AddWithValue("@fk_Pessoa_cpf", ingresso.cpfPessoa);
                comando.Parameters.AddWithValue("@fk_Evento_id", ingresso.idEvento);

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
        public void update(Ingresso ingresso)
        {
            try
            {
                
                openConnection();
                var comando = conexao.CreateCommand();
                comando = new MySqlCommand("UPDATE Ingresso SET valor = @valor, formaPagamento = @formaPagamento, fk_Pessoa_cpf = @fk_Pessoa_cpf, fk_Evento_id = @fk_Evento_id WHERE id = @id", conexao);
                comando.Parameters.AddWithValue("@valor", ingresso.valor);
                comando.Parameters.AddWithValue("@formaPagamento", ingresso.formaPagamento);
                comando.Parameters.AddWithValue("@fk_Pessoa_cpf", ingresso.cpfPessoa);
                comando.Parameters.AddWithValue("@fk_Evento_id", ingresso.idEvento);

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
        public List<Ingresso> getAllIngressos()
        {
            try
            {
                this.openConnection();

                var command = conexao.CreateCommand();
                MySqlCommand query = new MySqlCommand("select * from ingresso", conexao);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query);
                da.Fill(dt);

                return dt.DataTableToList<Ingresso>();
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
        public List<Ingresso> getMeusIngressos(String cpf)
        {
            try
            {
                this.openConnection();

                var command = conexao.CreateCommand();
                MySqlCommand query = new MySqlCommand("SELECT *, e.endereco as enderecoEvento, e.dataHora as dataHoraEvento, e.imgEvent as imgEvent, e.nome as nomeEvento FROM ingresso AS i JOIN evento AS e ON i.fk_Evento_id = e.id WHERE i.fk_Pessoa_cpf = '" + cpf + "'", conexao);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query);
                da.Fill(dt);

                return dt.DataTableToList<Ingresso>();
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
    }
}

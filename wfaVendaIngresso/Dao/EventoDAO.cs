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
    public class EventoDAO : Conexao
    {

        public void delete(Evento evento)
        {
            try
            {

                openConnection();
                var comando = conexao.CreateCommand();
                comando = new MySqlCommand("DELETE from evento WHERE id = @id", conexao);
                comando.Parameters.AddWithValue("@id", evento.id);
                

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

        public void insert(Evento evento)
        {
            
            try
            {
                openConnection();
                var comando = conexao.CreateCommand();
                comando = new MySqlCommand("INSERT INTO Evento(valorRecebido, valorGasto, valorIngresso, valorTaxas, nome, endereco, dataHora, imgEvent) VALUES (@valorRecebido, @valorGasto, @valorIngresso, @valorTaxas, @nome, @endereco, @dataHora, @imgEvent)", conexao);
                comando.Parameters.AddWithValue("@valorRecebido", evento.valorRecebido);
                comando.Parameters.AddWithValue("@valorGasto", evento.valorGasto);
                comando.Parameters.AddWithValue("@valorIngresso", evento.valorIngresso);
                comando.Parameters.AddWithValue("@valorTaxas", evento.valorTaxas);
                comando.Parameters.AddWithValue("@nome", evento.nome);
                comando.Parameters.AddWithValue("@endereco", evento.endereco);
                comando.Parameters.AddWithValue("@dataHora", evento.dataHora);
                comando.Parameters.AddWithValue("@imgEvent", evento.imgEvent);

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
        public void update(Evento evento)
        {
            try
            {
                openConnection();
                var comando = conexao.CreateCommand();
                comando = new MySqlCommand("UPDATE Evento SET valorRecebido = @valorRecebido, valorGasto = @valorGasto, valorIngresso = @valorIngresso, valorTaxas = @valorTaxas, nome = @nome, endereco = @endereco, dataHora = @dataHora, imgEvent = @imgEvent WHERE id = @id", conexao);
                comando.Parameters.AddWithValue("@valorRecebido", evento.valorRecebido);
                comando.Parameters.AddWithValue("@valorGasto", evento.valorGasto);
                comando.Parameters.AddWithValue("@valorIngresso", evento.valorIngresso);
                comando.Parameters.AddWithValue("@valorTaxas", evento.valorTaxas);
                comando.Parameters.AddWithValue("@nome", evento.nome);
                comando.Parameters.AddWithValue("@endereco", evento.endereco);
                comando.Parameters.AddWithValue("@dataHora", evento.dataHora);
                comando.Parameters.AddWithValue("@imgEvent", evento.imgEvent);
                comando.Parameters.AddWithValue("@id", evento.id);

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

        public List<Evento> getAllEventos()
        {
            try { 
                this.openConnection();

                var command = conexao.CreateCommand();
                MySqlCommand query = new MySqlCommand("select * from evento", conexao);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query);
                da.Fill(dt);

                return dt.DataTableToList<Evento>();
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

        public List<Evento> getMeusEventos(String cpf)
        {
            try
            {
                openConnection();
                var comando = conexao.CreateCommand();

                MySqlCommand query = new MySqlCommand("SELECT * FROM evento WHERE id IN (SELECT fk_Evento_id FROM gerenteEvento WHERE fk_Pessoa_cpf = '" + cpf + "')", conexao);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query);
                da.Fill(dt);

                return dt.DataTableToList<Evento>();
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

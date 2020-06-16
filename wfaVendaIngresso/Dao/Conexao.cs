using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace wfaVendaIngresso.Dao
{
    public class Conexao
    {
        string conecta = "DATABASE=vendaingressos; SERVER=localhost; UID=root; PWD=";
        protected MySqlConnection conexao = null;
        
        public void openConnection()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Open();
            }catch(Exception erro)
            {
                throw erro;
            }
            
        }

        public void closeConnection()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Close();

            }
            catch (Exception erro)
            {
                throw erro;
            }
           
        }
    }
}

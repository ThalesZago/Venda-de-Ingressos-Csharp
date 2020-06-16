using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfaVendaIngresso.Classes;
using wfaVendaIngresso.Dao;
namespace wfaVendaIngresso.Bll
{
    class PessoaBll
    {
        PessoaDAO pessoaDao = new PessoaDAO();

        public void update(Pessoa pessoa)
        {
            try
            {
                pessoaDao.update(pessoa);

            } catch(Exception erro)
            {
                throw erro;
            }

        }

        public void delete(Pessoa pessoa)
        {
            try
            {
                pessoaDao.delete(pessoa);
            } catch(Exception erro)
            {
                throw erro;
            }
        }

        public void insert(Pessoa pessoa)
        {
            try
            {
                pessoaDao.insert(pessoa);

            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
    }
}

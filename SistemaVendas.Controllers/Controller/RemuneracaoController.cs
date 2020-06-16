using SistemaVendas.Data.Context;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Controllers.Controller
{
    public class RemuneracaoController
    {
        private Retorno retorno = new Retorno();

        public List<RemuneracaoModel> ListarRemuneracaos(RemuneracaoModel remuneracao)
        {
            List<RemuneracaoModel> lista = new List<RemuneracaoModel>();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    lista = db.RemuneracaoDB.ToList();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return lista;
        }

        public RemuneracaoModel BuscarRemuneracao(int id)
        {
            RemuneracaoModel remuneracao = new RemuneracaoModel();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    remuneracao = db.RemuneracaoDB.Where(x => x.idRemuneracao == id).First();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return remuneracao;
        }

        public Retorno CadastrarRemuneracao(RemuneracaoModel remuneracao)
        {
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.RemuneracaoDB.Add(remuneracao);
                    db.SaveChanges();

                    retorno.Situacao = true;
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return retorno;
        }

        public Retorno AtualizarRemuneracao(RemuneracaoModel remuneracao)
        {

            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.RemuneracaoDB.Add(remuneracao);
                    db.SaveChanges();

                    retorno.Situacao = true;
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return retorno;
        }

        public Retorno ExcluirRemuneracao(int id)
        {
            RemuneracaoModel remuneracao = new RemuneracaoModel();
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    remuneracao = db.RemuneracaoDB.Where(x => x.idRemuneracao == id).First();

                    db.RemuneracaoDB.Remove(remuneracao);
                    db.SaveChanges();

                    retorno.Situacao = true;
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return retorno;
        }
    }
}

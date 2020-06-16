using SistemaVendas.Data.Context;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Controllers.Controller
{
    public class GerenciamentoController
    {
        private Retorno retorno = new Retorno();

        public List<GerenciamentoModel> ListarGerenciamentos()
        {
            List<GerenciamentoModel> lista = new List<GerenciamentoModel>();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    lista = db.GerenciamentoDB.ToList();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return lista;
        }

        public GerenciamentoModel BuscarGerenciamento(int id)
        {
            GerenciamentoModel gerenciamento = new GerenciamentoModel();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    gerenciamento = db.GerenciamentoDB.Where(x => x.idGerenciamento == id).First();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return gerenciamento;
        }

        public Retorno CadastrarGerenciamento(GerenciamentoModel gerenciamento)
        {
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.GerenciamentoDB.Add(gerenciamento);
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

        public Retorno AtualizarGerenciamento(GerenciamentoModel gerenciamento)
        {

            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.GerenciamentoDB.Add(gerenciamento);
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

        public Retorno ExcluirGerenciamento(int id)
        {
            GerenciamentoModel gerenciamento = new GerenciamentoModel();
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    gerenciamento = db.GerenciamentoDB.Where(x => x.idGerenciamento == id).First();

                    db.GerenciamentoDB.Remove(gerenciamento);
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

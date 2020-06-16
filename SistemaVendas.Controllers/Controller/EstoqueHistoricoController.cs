using SistemaVendas.Data.Context;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Controllers.Controller
{
    public class EstoqueHistoricoController
    {
        private Retorno retorno = new Retorno();

        public List<EstoqueHistoricoModel> ListarEstoquesHistorico()
        {
            List<EstoqueHistoricoModel> lista = new List<EstoqueHistoricoModel>();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    lista = db.EstoqueHistoricoDB.ToList();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return lista;
        }

        public EstoqueHistoricoModel BuscarEstoqueHistorico(Int64 id)
        {
            EstoqueHistoricoModel estoqueHistorico = new EstoqueHistoricoModel();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    estoqueHistorico = db.EstoqueHistoricoDB.Where(x => x.IdEstoque_Historico == id).First();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return estoqueHistorico;
        }

        public Retorno CadastrarEstoqueHistorico(EstoqueHistoricoModel estoqueHistorico)
        {
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.EstoqueHistoricoDB.Add(estoqueHistorico);
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

        public Retorno AtualizarEstoque(EstoqueHistoricoModel estoqueHistorico)
        {

            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.EstoqueHistoricoDB.Add(estoqueHistorico);
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

        public Retorno ExcluirEstoque(int id)
        {
            EstoqueHistoricoModel estoqueHistorico = new EstoqueHistoricoModel();
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    estoqueHistorico = db.EstoqueHistoricoDB.Where(x => x.IdEstoque_Historico == id).First();

                    db.EstoqueHistoricoDB.Remove(estoqueHistorico);
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

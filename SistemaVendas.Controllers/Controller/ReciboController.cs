using SistemaVendas.Data.Context;
using SistemaVendas.Models;
using SistemaVendas.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Controllers.Controller
{
    public class ReciboController
    {
        private Retorno retorno = new Retorno();

        public List<ReciboModel> ListarRecibos()
        {
            List<ReciboModel> lista = new List<ReciboModel>();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    lista = db.ReciboDB
                            .Join(db.ProdutoDB,
                                recibo => recibo.idProdutoRecibo,
                                produto => produto.idProduto,
                                (recibo, produto) => new { recibo, produto })
                            .Join(db.VendaDB,
                                x => x.recibo.idVendaRecibo,
                                vendas => vendas.idVenda,
                                (x, vendas) => new { x, vendas })
                            .ToList()
                            .Select(recibo => new ReciboModel
                            {
                                idRecibo = recibo.x.recibo.idRecibo,
                                CustoProdutoRecibo = recibo.x.recibo.CustoProdutoRecibo,
                                VendaProdutoRecibo = recibo.x.recibo.VendaProdutoRecibo,
                                qdadeProdutoRecibo = recibo.x.recibo.qdadeProdutoRecibo,
                                dataRecibo = recibo.x.recibo.dataRecibo,
                                produtoRecibo = recibo.x.produto,
                                vendaRecibo = recibo.vendas
                            })
                            .ToList();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return lista;
        }

        public ReciboModel BuscarRecibo(int id)
        {
            ReciboModel recibo = new ReciboModel();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    recibo = db.ReciboDB.Where(x => x.idRecibo == id).First();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return recibo;
        }

        public Retorno CadastrarRecibo(ReciboModel recibo)
        {
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.ReciboDB.Add(recibo);
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

        public Retorno AtualizarRecibo(ReciboModel recibo)
        {

            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.ReciboDB.Add(recibo);
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

        public Retorno ExcluirRecibo(int id)
        {
            ReciboModel recibo = new ReciboModel();
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    recibo = db.ReciboDB.Where(x => x.idRecibo == id).First();

                    db.ReciboDB.Remove(recibo);
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

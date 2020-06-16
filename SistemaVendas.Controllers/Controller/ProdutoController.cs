using SistemaVendas.Data.Context;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Controllers.Controller
{
    public class ProdutoController
    {
        private Retorno retorno = new Retorno();

        public List<ProdutoModel> ListarProdutos()
        {
            List<ProdutoModel> lista = new List<ProdutoModel>();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    lista = db.ProdutoDB.ToList();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return lista;
        }

        public ProdutoModel BuscarProduto(string id)
        {
            ProdutoModel produto = new ProdutoModel();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    produto = db.ProdutoDB.Where(x => x.idProduto == id).FirstOrDefault();
                    produto = produto != null ? produto : throw new Exception();

                    retorno.Situacao = true;
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;

                produto = new ProdutoModel();
            }
            finally
            {
                produto.Retorno = retorno;
            }

            return produto;
        }

        public Retorno CadastrarProduto(ProdutoModel produto)
        {
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.ProdutoDB.Add(produto);
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

        public Retorno AtualizarProduto(ProdutoModel produto)
        {

            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.ProdutoDB.Add(produto);
                    
                    //Indica Update na tabela
                    db.Entry<ProdutoModel>(produto).State = System.Data.Entity.EntityState.Modified;

                    //Salva o item
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

        public Retorno ExcluirProduto(string id)
        {
            ProdutoModel produto = new ProdutoModel();
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    produto = db.ProdutoDB.Where(x => x.idProduto == id).FirstOrDefault();

                    db.ProdutoDB.Remove(produto);
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

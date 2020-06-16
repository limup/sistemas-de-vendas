using SistemaVendas.Data.Context;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Controllers.Controller
{
    public class EstoqueController
    {
        private Retorno retorno = new Retorno();

        public List<EstoqueModel> ListarEstoques()
        {
            List<EstoqueModel> lista = new List<EstoqueModel>();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    lista = db.EstoqueDB.ToList();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return lista;
        }

        public EstoqueModel BuscarEstoque(Int64 idEstoque)
        {
            EstoqueModel estoque = new EstoqueModel();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    estoque = db.EstoqueDB.Where(x => x.idProdutoEstoque == idEstoque.ToString()).First();
                    estoque = estoque != null ? estoque : throw new Exception();

                    retorno.Situacao = true;
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;

                estoque = new EstoqueModel();
            }
            finally
            {
                estoque.Retorno = retorno;
            }

            return estoque;
        }

        public Retorno CadastrarEstoque(EstoqueModel estoque)
        {
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.EstoqueDB.Add(estoque);
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

        public Retorno AtualizarEstoque(EstoqueModel estoque)
        {

            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.EstoqueDB.Add(estoque);

                    //Indica Update na tabela
                    db.Entry<EstoqueModel>(estoque).State = System.Data.Entity.EntityState.Modified;

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
            EstoqueModel estoque = new EstoqueModel();
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    estoque = db.EstoqueDB.Where(x => x.idEstoque == id).First();

                    db.EstoqueDB.Remove(estoque);
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

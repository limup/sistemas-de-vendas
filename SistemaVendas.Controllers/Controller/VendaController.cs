using SistemaVendas.Data.Context;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Controllers.Controller
{
    public class VendaController
    {
        private Retorno retorno = new Retorno();

        public List<VendaModel> ListarVendas()
        {
            List<VendaModel> lista = new List<VendaModel>();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    lista = db.VendaDB.ToList();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return lista;
        }

        public VendaModel BuscarVenda(int id)
        {
            VendaModel venda = new VendaModel();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    venda = db.VendaDB.Where(x => x.idVenda == id).First();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return venda;
        }

        public Retorno CadastrarVenda(VendaModel venda)
        {
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.VendaDB.Add(venda);
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

        public Retorno AtualizarVenda(VendaModel venda)
        {

            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.VendaDB.Add(venda);
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

        public Retorno ExcluirVenda(int id)
        {
            VendaModel venda = new VendaModel();
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    venda = db.VendaDB.Where(x => x.idVenda == id).First();

                    db.VendaDB.Remove(venda);
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

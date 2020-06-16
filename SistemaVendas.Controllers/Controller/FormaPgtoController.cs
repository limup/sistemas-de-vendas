using SistemaVendas.Data.Context;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Controllers.Controller
{
    public class FormaPgtoController
    {
        private Retorno retorno = new Retorno();

        public List<FormaPgtoModel> ListarFormaPgto()
        {
            List<FormaPgtoModel> lista = new List<FormaPgtoModel>();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    lista = db.FormaPgtoDB.ToList();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return lista;
        }

        public FormaPgtoModel BuscarFormaPgto(int id)
        {
            FormaPgtoModel formapgto = new FormaPgtoModel();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    formapgto = db.FormaPgtoDB.Where(x => x.idFormaPgto == id).First();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return formapgto;
        }

        public Retorno CadastrarFormaPgto(FormaPgtoModel formapgto)
        {
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.FormaPgtoDB.Add(formapgto);
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

        public Retorno AtualizarFormaPgto(FormaPgtoModel formapgto)
        {

            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.FormaPgtoDB.Add(formapgto);
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

        public Retorno ExcluirFormaPgto(int id)
        {
            FormaPgtoModel formapgto = new FormaPgtoModel();
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    formapgto = db.FormaPgtoDB.Where(x => x.idFormaPgto == id).First();

                    db.FormaPgtoDB.Remove(formapgto);
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

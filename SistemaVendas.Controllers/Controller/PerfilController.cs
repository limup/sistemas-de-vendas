using SistemaVendas.Data.Context;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Controllers.Controller
{
    public class PerfilController
    {
        private Retorno retorno = new Retorno();

        public List<PerfilModel> ListarPerfils(PerfilModel perfil)
        {
            List<PerfilModel> lista = new List<PerfilModel>();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    lista = db.PerfilDB.ToList();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return lista;
        }

        public PerfilModel BuscarPerfil(int id)
        {
            PerfilModel perfil = new PerfilModel();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    perfil = db.PerfilDB.Where(x => x.idPerfil == id).First();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return perfil;
        }

        public Retorno CadastrarPerfil(PerfilModel perfil)
        {
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.PerfilDB.Add(perfil);
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

        public Retorno AtualizarPerfil(PerfilModel perfil)
        {

            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.PerfilDB.Add(perfil);
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

        public Retorno ExcluirPerfil(int id)
        {
            PerfilModel perfil = new PerfilModel();
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    perfil = db.PerfilDB.Where(x => x.idPerfil == id).First();

                    db.PerfilDB.Remove(perfil);
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

using SistemaVendas.Data.Context;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Controllers.Controller
{
    public class UsuarioController
    {
        private Retorno retorno = new Retorno();

        public List<UsuarioModel> ListarUsuarios(UsuarioModel usuario)
        {
            List<UsuarioModel> lista = new List<UsuarioModel>();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    lista = db.UsuarioDB.ToList();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;

                lista = null;

                //Registra no log
            }

            return lista;
        }

        public UsuarioModel BuscarUsuario(int id)
        {
            UsuarioModel usuario = new UsuarioModel();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    usuario = db.UsuarioDB.Where(x => x.idUsuario == id).FirstOrDefault();
                    usuario = usuario != null ? usuario : new UsuarioModel();

                    retorno.Situacao = true;
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;

                //Registra no log
            }
            finally
            {
                    usuario.Retorno = retorno;
            }

            return usuario;
        }

        public Retorno CadastrarUsuario(UsuarioModel usuario)
        {
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.UsuarioDB.Add(usuario);
                    db.SaveChanges();

                    retorno.Situacao = true;
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;

                //Registra no log
            }

            return retorno;
        }

        public Retorno AtualizarUsuario(UsuarioModel usuario)
        {

            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.UsuarioDB.Add(usuario);
                    db.SaveChanges();

                    retorno.Situacao = true;
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;

                //Registra no log
            }

            return retorno;
        }

        public Retorno ExcluirUsuario(int id)
        {
            UsuarioModel usuario = new UsuarioModel();
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    usuario = db.UsuarioDB.Where(x => x.idUsuario == id).First();

                    db.UsuarioDB.Remove(usuario);
                    db.SaveChanges();

                    retorno.Situacao = true;
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;

                //Registra no log
            }

            return retorno;
        }

        public bool ValidarAcesso(int idusuario, string senhausuario)
        {
            bool darAcesso = false;

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    if (db.UsuarioDB.Where(x => x.idUsuario == idusuario && x.senhaUsuario == senhausuario).Count() != 0)
                    {
                        darAcesso = true;
                    }
                    else
                    {
                        darAcesso = false;
                    }
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;

                //Registra no log
            }

            return darAcesso;
        }

        public bool ValidarAcesso(int idusuario, string senhausuario, int idcargo)
        {
            bool darAcesso = false;

            UsuarioModel usuario;

            int cargo;

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    usuario = db.UsuarioDB.Where(x => x.idUsuario == idusuario && x.senhaUsuario == senhausuario).FirstOrDefault();
                    cargo = db.FuncionarioDB.Where(x => x.idFuncionario == usuario.idFuncionarioUsuario).FirstOrDefault().idCargoFuncionario;

                    if (cargo.Equals(idcargo))
                    {
                        darAcesso = true;
                    }
                    else
                    {
                        darAcesso = false;
                    }
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;

                //Registra no log
            }

            return darAcesso;
        }
    }
}

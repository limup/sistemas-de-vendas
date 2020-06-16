using SistemaVendas.Data.Context;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Controllers.Controller
{
    public class FuncionarioController
    {
        private Retorno retorno = new Retorno();

        public List<FuncionarioModel> ListarFuncionarios()
        {
            List<FuncionarioModel> lista = new List<FuncionarioModel>();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    lista = db.FuncionarioDB.ToList();
                }
            }
            catch (Exception ex)
            {
                lista = new List<FuncionarioModel>();
            }

            return lista;
        }

        public FuncionarioModel BuscarFuncionario(int id)
        {
            FuncionarioModel funcionario = new FuncionarioModel();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    funcionario = db.FuncionarioDB.Where(x => x.idFuncionario == id).First();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return funcionario;
        }

        public FuncionarioModel BuscarVendedor(int id)
        {
            FuncionarioModel funcionario = new FuncionarioModel();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    int cargo = Convert.ToInt32(Models.Cargo.Vendedor);
                    funcionario = db.FuncionarioDB.Where(x =>  x.idFuncionario == id && x.idCargoFuncionario == cargo).First();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return funcionario;
        }

        public Retorno CadastrarFuncionario (FuncionarioModel funcionario)
        {
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.FuncionarioDB.Add(funcionario);
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

        public Retorno AtualizarFuncionario(FuncionarioModel funcionario)
        {

            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.FuncionarioDB.Add(funcionario);
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

        public Retorno ExcluirFuncionario(int id)
        {
            FuncionarioModel funcionario = new FuncionarioModel();
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    funcionario = db.FuncionarioDB.Where(x => x.idFuncionario == id).First();

                    db.FuncionarioDB.Remove(funcionario);
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

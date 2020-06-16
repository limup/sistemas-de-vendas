using SistemaVendas.Data.Context;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Controllers.Controller
{
    class CargoController
    {
        private Retorno retorno = new Retorno();

        public List<CargoModel> ListarCargos(CargoModel cargo)
        {
            List<CargoModel> lista = new List<CargoModel>();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    lista = db.CargoDB.ToList();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return lista;
        }

        public CargoModel BuscarCargo(int id)
        {
            CargoModel cargo = new CargoModel();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    cargo = db.CargoDB.Where(x => x.idCargo == id).First();
                }
            }
            catch (Exception ex)
            {
                retorno.Situacao = false;
                retorno.Erro = ex;
            }

            return cargo;
        }

        public Retorno CadastrarCargo(CargoModel cargo)
        {
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.CargoDB.Add(cargo);
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

        public Retorno AtualizarCargo(CargoModel cargo)
        {

            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.CargoDB.Add(cargo);
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

        public Retorno ExcluirCargo(int id)
        {
            CargoModel cargo = new CargoModel();
            Retorno retorno = new Retorno();

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    cargo = db.CargoDB.Where(x => x.idCargo == id).First();

                    db.CargoDB.Remove(cargo);
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

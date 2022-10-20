using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Data.Context
{
    public class MySqlInitializer : IDatabaseInitializer<DatabaseContext>
    {
        public void InitializeDatabase(DatabaseContext context)
        {
            if (!context.Database.Exists())
            {
                context.Database.Create();

                //Cadastra os perfis obrigatórios
                context.PerfilDB.Add(
                    new Models.PerfilModel
                    {
                        idPerfil = 1,
                        tipoPerfil = "Administrador",
                        descricaoPerfil = "Tudo"
                    });

                context.PerfilDB.Add(
                    new Models.PerfilModel
                    {
                        idPerfil = 2,
                        tipoPerfil = "Controlador",
                        descricaoPerfil = "Cadastro de produtos, Entrada de estoque, retirada de estoque, Cadastro de Funcionários, Cadastros de usuários, Relatórios"
                    });

                context.PerfilDB.Add(
                    new Models.PerfilModel
                    {
                        idPerfil = 3,
                        tipoPerfil = "Master",
                        descricaoPerfil = "Registros de vendas, Cancelamentos, Relatórios"
                    });

                context.PerfilDB.Add(
                    new Models.PerfilModel
                    {
                        idPerfil = 4,
                        tipoPerfil = "Basico",
                        descricaoPerfil = "Relatórios"
                    });

                context.SaveChanges();

                //Cadastra cargos 
                context.CargoDB.Add(new Models.CargoModel
                {
                    idCargo = 1,
                    nomeCargo = "Gerente de Vendas"
                });

                context.CargoDB.Add(new Models.CargoModel
                {
                    idCargo = 2,
                    nomeCargo = "Vendedora"
                });

                context.CargoDB.Add(new Models.CargoModel
                {
                    idCargo = 3,
                    nomeCargo = "Operadora de Caixa"
                });

                context.SaveChanges();

                //Cadastra funcionario master
                context.FuncionarioDB.Add(
                    new Models.FuncionarioModel
                    {
                        idFuncionario = 1,
                        idRemuneracaoFuncionario = 1,
                        nomeFuncionario = "Arnaldo Junior",
                        empresaFuncionario = "Limup",
                        dataAdmissaoFuncionario = DateTime.Now
                    });

                context.SaveChanges();

                //Cadastra usuario
                context.UsuarioDB.Add(
                    new Models.UsuarioModel
                    {
                        idUsuario = 004001228,
                        idFuncionarioUsuario = 1,
                        idPerfilUsuario = 1,
                        senhaUsuario = "92903738"
                        
                    });

                context.SaveChanges();
            }
        }
    }
}

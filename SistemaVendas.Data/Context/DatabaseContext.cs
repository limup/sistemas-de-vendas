using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Data.Context
{
    public class DatabaseContext : DbContext
    {
        static DatabaseContext()
        {
            Database.SetInitializer(new MySqlInitializer());
        }

        public DatabaseContext() 
            : base(nameOrConnectionString: "capimbambu") { }

        public DbSet<CargoModel> CargoDB { get; set; }
        public DbSet<EstoqueModel> EstoqueDB { get; set; }
        public DbSet<EstoqueHistoricoModel> EstoqueHistoricoDB { get; set; }
        public DbSet<FormaPgtoModel> FormaPgtoDB { get; set; }
        public DbSet<FuncionarioModel> FuncionarioDB { get; set; }
        public DbSet<GerenciamentoModel> GerenciamentoDB { get; set; }
        public DbSet<PerfilModel> PerfilDB { get; set; }
        public DbSet<ProdutoModel> ProdutoDB { get; set; }
        public DbSet<ReciboModel> ReciboDB { get; set; }
        public DbSet<RemuneracaoModel> RemuneracaoDB { get; set; }
        public DbSet<UsuarioModel> UsuarioDB { get; set; }
        public DbSet<VendaModel> VendaDB { get; set; }


    }
}

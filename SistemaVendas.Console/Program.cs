using SistemaVendas.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Verificando conexão com MySql...");
            using (DatabaseContext db = new DatabaseContext())
            {
                System.Console.WriteLine("Verificando schema...");
                if (!db.Database.Exists()) { System.Console.WriteLine("Criando schema..."); db.Database.Create(); }

                System.Console.WriteLine("Quantidade de registro na tabela produto...");
                System.Console.WriteLine(db.ProdutoDB.Count().ToString());

                System.Console.WriteLine("Listando registro da tabela Produto...");
                List<SistemaVendas.Models.ProdutoModel> produtos = db.ProdutoDB.ToList();

                foreach (var prod in produtos)
                {
                    System.Console.WriteLine(prod.idProduto + " " + prod.descricaoProduto + " " + prod.marcaProduto);
                }

                System.Console.WriteLine("Teste Finalizado com sucesso!");
                System.Console.ReadLine();

            }
        }
    }
}

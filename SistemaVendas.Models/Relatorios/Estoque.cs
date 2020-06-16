namespace SistemaVendas.Models.Relatorios
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Estoque
    {
        public string Produto { get; set; }

        public string Descricao { get; set; }

        public string Entrada { get; set; }

        public string Saida { get; set; }

        public string EstoqueAtual { get; set; }

        public string DataMovimentacao { get; set; }


    }
}

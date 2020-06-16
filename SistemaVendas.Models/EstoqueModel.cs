namespace SistemaVendas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.OleDb;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Table("estoque")]
    public class EstoqueModel
    {
        #region Atributos

        [Key]
        [Column("idEstoque")]
        public int idEstoque { get; set; }

        public string idProdutoEstoque { get; set; }

        public int entradaEstoque { get; set; }

        public int saidaEstoque { get; set; }

        public int atualEstoque { get; set; }

        public DateTime dataUltMovimentacaoEstoque { get; set; }

        public string situacaoEstoque { get; set; }

        public DateTime cadastroEstoque { get; set; }

        #endregion

        #region Objetos

        public Retorno Retorno;

        #endregion

        #region Virtual

        [ForeignKey("idProdutoEstoque")]
        public virtual ProdutoModel produtoEstoque { get; set; }

        #endregion

        public EstoqueModel()
        {
            Retorno = new Retorno();
        }

    }
}

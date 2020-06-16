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

    [Table("estoque_historico")]
    public class EstoqueHistoricoModel
    {
        #region Atributos

        [Key]
        [Column("IdEstoque_historico")]
        public int IdEstoque_Historico { get; set; }

        public string IdProdutoEstoque_Historico { get; set; }

        public int EntradaEstoque_Historico { get; set; }

        public int SaidaEstoque_Historico { get; set; }

        public int AtualEstoque_Historico { get; set; }

        public DateTime DataUltMovimentacaoEstoque_Historico { get; set; }

        public string SituacaoEstoque_Historico { get; set; }

        public DateTime CadastroEstoque_Historico { get; set; }

        public string IdUsuarioEstoque_Historico { get; set; }

        #endregion

        #region Objetos

        public Retorno Retorno;

        #endregion

        #region Virtual


        #endregion

        public EstoqueHistoricoModel()
        {
            Retorno = new Retorno();
        }

    }
}

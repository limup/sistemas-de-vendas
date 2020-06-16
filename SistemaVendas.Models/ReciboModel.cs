namespace SistemaVendas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.OleDb;

    /// <summary>
    /// Classe responsável por receber ou setar informações de Recibo
    /// </summary>
    /// 
    [Table("recibo")]
    public class ReciboModel
    {
        #region Atributos
        [Key]
        [Column("idRecibo")]
        public int idRecibo { get; set; }

        public int idVendaRecibo { get; set; }

        public string idProdutoRecibo { get; set; }

        public int qdadeProdutoRecibo { get; set; }

        public decimal CustoProdutoRecibo { get; set; }

        public decimal VendaProdutoRecibo { get; set; }

        public DateTime dataRecibo { get; set; }

        #endregion

        #region Objetos

        public Retorno Retorno;

        #endregion

        #region Virtual

        [ForeignKey("idVendaRecibo")]
        public virtual VendaModel vendaRecibo { get; set; }

        [ForeignKey("idProdutoRecibo")]
        public virtual ProdutoModel produtoRecibo { get; set; }

        #endregion

        public ReciboModel()
        {
            vendaRecibo = new VendaModel();
            produtoRecibo = new ProdutoModel();

            Retorno = new Retorno();
        }
    }
}

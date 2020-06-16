namespace SistemaVendas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.OleDb;

    /// <summary>
    /// Classe que contém os objetos de informações de Vendas
    /// </summary>
    /// 
    [Table("venda")]
    public class VendaModel
    {
        #region Atributos

        /// <summary>
        /// Identificador da Venda
        /// </summary>
        /// 
        [Key]
        [Column("idVenda")]
        public int idVenda { get; set; }

        public int idFuncionarioVendedorVenda { get; set; }

        public int idFormaPgtoVenda { get; set; }

        public decimal valorRecebidoVenda { get; set; }

        public decimal descontoVenda { get; set; }

        public decimal acrescimoVenda { get; set; }

        public decimal totalVenda { get; set; }

        public decimal trocoVenda { get; set; }

        public DateTime dataVenda { get; set; }

        #endregion

        #region Objetos

        public Retorno Retorno;
        
        public List<ReciboModel> Recibo { get; set; }

        #endregion

        #region Virtual

        [ForeignKey("idFuncionarioVendedorVenda")]
        public virtual FuncionarioModel funcionarioVendedorVenda { get; set; }

        [ForeignKey("idFormaPgtoVenda")]
        public virtual FormaPgtoModel formaPgtoVenda { get; set; }

        #endregion

        /// <summary>
        /// Inicialização de objetos
        /// </summary>
        public VendaModel()
        {
            Recibo = new List<ReciboModel>();
            Retorno = new Retorno();
        }

    }
}

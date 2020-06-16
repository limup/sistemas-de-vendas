namespace SistemaVendas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.OleDb;

    /// <summary>
    /// Classe responsável por receber ou setar informações de Produto
    /// </summary>
    /// 
    [Table("produto")]
    public class ProdutoModel 
    {
        #region Atributos

        /// <summary>
        /// Identificador do Produto
        /// </summary>
        /// 
        [Key]
        [Column("idProduto")]
        public string idProduto { get; set; }
        
        /// <summary>
        /// Descrição do produto
        /// </summary>
        public string descricaoProduto { get; set; }
        
        /// <summary>
        /// Marca do produto
        /// </summary>
        public string marcaProduto { get; set; }
        
        /// <summary>
        /// Valor da venda do produto
        /// </summary>
        public decimal vendaProduto { get; set; }
        
        /// <summary>
        /// Valor do custo do produto
        /// </summary>
        public decimal custoProduto { get; set; }
        
        /// <summary>
        /// Nome da foto
        /// </summary>
        public string caminhoFotoProduto { get; set; }

        /// <summary>
        /// Data de cadastro do produto
        /// </summary>
        public DateTime dataCadastroProduto { get; set; }

        #endregion

        #region Objetos

        /// <summary>
        /// 
        /// </summary>
        public Retorno Retorno;

        #endregion

        /// <summary>
        /// 
        /// </summary>
        public ProdutoModel()
        {
            Retorno = new Retorno();
        }

    }
}

namespace SistemaVendas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.OleDb;

    [Table("gerenciamento")]
    public class GerenciamentoModel
    {
        #region Atributos

        [Key]
        [Column("idGerenciamento")]
        public int idGerenciamento { get; set; }

        public string elementoGerenciamento { get; set; }

        public DateTime dataGerenciamento { get; set; }

        public decimal valorGerenciamento { get; set; }

        public string vendedorGerenciamento { get; set; }

        public string motivoGerenciamento { get; set; }

        #endregion

        #region Objetos

        public Retorno Retorno;

        #endregion

        public GerenciamentoModel()
        {
            Retorno = new Retorno();
        }
    }
}


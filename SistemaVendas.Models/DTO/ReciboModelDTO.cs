using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Models.DTO
{
    public class ReciboModelDTO
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

        public ReciboModelDTO()
        {
            vendaRecibo = new VendaModel();
            produtoRecibo = new ProdutoModel();

            Retorno = new Retorno();
        }
    }
}

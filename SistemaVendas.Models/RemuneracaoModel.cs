using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Models
{
    [Table("remuneracao")]
    public class RemuneracaoModel
    {
        #region Atributos

        [Key]
        [Column("idRemuneracao")]
        public int idRemuneracao { get; set; }

        public string salarioBaseRemuneracao { get; set; }

        #endregion

        #region Objetos

        public Retorno Retorno;

        #endregion

        public RemuneracaoModel()
        {
            Retorno = new Retorno();
        }
    }
}

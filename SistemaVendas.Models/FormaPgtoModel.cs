using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Models
{
    [Table("formapgto")]
    public class FormaPgtoModel
    {
        #region  Atributos

        [Key]
        [Column("idFormaPgto")]
        public int idFormaPgto { get; set; }

        public string descricaoFormaPgto { get; set; }

        #endregion

        #region Objetos

        public Retorno Retorno;

        #endregion

        public FormaPgtoModel()
        {
            Retorno = new Retorno();
        }
    }
}

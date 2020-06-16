using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Models
{
    [Table("cargo")]
    public class CargoModel
    {
        #region Atributos

        [Key]
        [Column("idCargo")]
        public int idCargo { get; set; }

        public string nomeCargo { get; set; }

        #endregion

        #region Objetos

        public Retorno Retorno;

        #endregion

        public CargoModel()
        {
            Retorno = new Retorno();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Models
{
    [Table("perfil")]
    public class PerfilModel
    {
        #region Atributos

        [Key]
        public int idPerfil { get; set; }

        public string tipoPerfil { get; set; }

        public string descricaoPerfil { get; set; }

        #endregion

        #region Objeto

        public Retorno Retorno;

        #endregion

        public PerfilModel()
        {
            Retorno = new Retorno();
        }
    }
}

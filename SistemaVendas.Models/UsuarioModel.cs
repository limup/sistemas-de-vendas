using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Models
{
    [Table("usuario")]
    public class UsuarioModel
    {
        #region Atributos

        [Key]
        [Column("idUsuario")]
        public int idUsuario { get; set; }

        public int idFuncionarioUsuario { get; set; }

        public int idPerfilUsuario { get; set; }

        public string senhaUsuario { get; set; }

        #endregion

        #region Objetos

        public Retorno Retorno;

        #endregion

        #region Virtual

        [ForeignKey("idFuncionarioUsuario")]
        public virtual FuncionarioModel funcionarioUsuario { get; set; }

        [ForeignKey("idPerfilUsuario")]
        public virtual PerfilModel perfilUsuario { get; set; }

        #endregion

        public UsuarioModel()
        {
            Retorno = new Retorno();
        }
    }
}

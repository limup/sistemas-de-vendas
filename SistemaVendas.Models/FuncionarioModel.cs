using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Models
{
    [Table("funcionario")]
    public class FuncionarioModel
    {
        #region Atributos

        [Key]
        [Column("idFuncionario")]
        public int idFuncionario { get; set; }

        public int idCargoFuncionario { get; set; }

        public int idRemuneracaoFuncionario { get; set; }

        public string nomeFuncionario { get; set; }

        public string empresaFuncionario { get; set; }

        public DateTime dataAdmissaoFuncionario { get; set; }

        #endregion

        #region Objetos

        public Retorno Retorno;

        #endregion

        #region Virtual

        [ForeignKey("idCargoFuncionario")]
        public virtual CargoModel cargoFuncionario { get; set; }

        [ForeignKey("idRemuneracaoFuncionario")]
        public virtual RemuneracaoModel remuneracaoFuncionario { get; set; }

        #endregion

        public FuncionarioModel()
        {
            cargoFuncionario = new CargoModel();
            remuneracaoFuncionario = new RemuneracaoModel();

            Retorno = new Retorno();
        }
    }
}

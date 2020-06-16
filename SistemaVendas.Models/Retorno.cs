namespace SistemaVendas.Models
{
    using System;

    /// <summary>
    /// Classe responsável por realizar o tratamento do erro
    /// </summary>
    public class Retorno
    {
        /// <summary>
        /// Trata a situação da requisição desta classe
        /// </summary>
        public bool Situacao;

        /// <summary>
        /// Mensagem de erro, caso existir
        /// </summary>
        public Exception Erro;
    }
}

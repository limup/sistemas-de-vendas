namespace SistemaVendas.Models
{
    public enum SolicitacaoForm
    {
        Consulta = 1,
        Cadastro = 2,
        Entrada = 3,
        Retirada = 4,
        Historico = 5,
        Autenticar = 6
    }

    public enum SolicitacaoButtom
    {
        Null = 0,
        Editar = 1,
        Salvar = 2
    }

    public enum Perfil
    {
        Administrador = 0,
        Controlador = 1,
        Master = 2,
        Basico = 3
    }

    public enum Cargo
    {
        Gerente = 1,
        Vendedor = 2,
        Operador = 3
    }
}

namespace SistemaVendas.Models.Relatorios
{
    public class Vendas
    {
        public string Numero { get; set; }
        
        public string Produto { get; set; }
        
        public int Quantidade { get; set; }
        
        public decimal Unitario { get; set; }
        
        public decimal Total { get; set; }
        
        public string Faturamento { get; set; }
    }
}

namespace SOLID.SRP
{
    public class Pedido_V
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }

        // Faz tudo sozinho → VIOLA SRP
        public decimal CalcularImposto() => Valor * 0.1m;

        public void Salvar()
        {
            System.Console.WriteLine("[SRP - Violação] Salvando pedido no banco...");
        }

        public void Imprimir()
        {
            System.Console.WriteLine("[SRP - Violação] Imprimindo pedido...");
        }
    }
}

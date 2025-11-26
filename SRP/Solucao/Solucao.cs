namespace SOLID.SRP
{
    public class Pedido_S
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public decimal CalcularImposto() => Valor * 0.1m;
    }

    public class PedidoRepositorio
    {
        public void Salvar(Pedido_S p)
        {
            System.Console.WriteLine("[SRP - Solução] Pedido salvo no banco.");
        }
    }

    public class PedidoImpressor
    {
        public void Imprimir(Pedido_S p)
        {
            System.Console.WriteLine("[SRP - Solução] Pedido impresso.");
        }
    }
}

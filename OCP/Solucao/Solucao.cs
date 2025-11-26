namespace SOLID.OCP
{
    public interface IPagamento
    {
        void Pagar();
    }

    public class PagamentoCartao : IPagamento
    {
        public void Pagar() => System.Console.WriteLine("[OCP - Solução] Pagamento com cartão.");
    }

    public class PagamentoPix : IPagamento
    {
        public void Pagar() => System.Console.WriteLine("[OCP - Solução] Pagamento com PIX.");
    }

    public class ProcessadorPagamento_S
    {
        public void Processar(IPagamento pagamento)
        {
            pagamento.Pagar(); // aberto para extensão, fechado para mudança
        }
    }
}

namespace SOLID.OCP
{
    public class ProcessadorPagamento_V
    {
        public void Pagar(string tipo)
        {
            if (tipo == "cartao")
                System.Console.WriteLine("[OCP - Violação] Pagando com cartão...");
            else if (tipo == "pix")
                System.Console.WriteLine("[OCP - Violação] Pagando com PIX...");
            else
                System.Console.WriteLine("[OCP - Violação] Método não suportado.");
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== INÍCIO DO TESTE =====\n");

        // SRP - Violação
        SafeRun("SRP - Violação", () =>
        {
            // exemplo: se a sua classe se chamar Pedido_V e método Imprimir()
            new SOLID.SRP.Pedido_V().Imprimir();
        });

        // SRP - Solução
        SafeRun("SRP - Solução", () =>
        {
            var p = new SOLID.SRP.Pedido_S { Id = 1, Valor = 100 };
            new SOLID.SRP.PedidoImpressor().Imprimir(p);
        });

        // OCP - Violação
        SafeRun("OCP - Violação", () =>
        {
            new SOLID.OCP.ProcessadorPagamento_V().Pagar("cartao");
        });

        // OCP - Solução
        SafeRun("OCP - Solução", () =>
        {
            new SOLID.OCP.ProcessadorPagamento_S().Processar(new SOLID.OCP.PagamentoPix());
        });

        // LSP - Violação
        SafeRun("LSP - Violação", () =>
        {
            var r = new SOLID.LSP.Retangulo_V { Largura = 3, Altura = 4 };
            Console.WriteLine($"Area (Retangulo_V): {r.Area()}");
            var q = new SOLID.LSP.Quadrado_V();
            q.Largura = 5; // se implementada assim
            Console.WriteLine($"Area (Quadrado_V como Retangulo): {q.Area()}");
        });

        // LSP - Solução
        SafeRun("LSP - Solução", () =>
        {
            var r = new SOLID.LSP.Retangulo_S { Largura = 2, Altura = 3 };
            var q = new SOLID.LSP.Quadrado_S { Lado = 4 };
            Console.WriteLine($"Area Retangulo_S: {r.Area()}");
            Console.WriteLine($"Area Quadrado_S: {q.Area()}");
        });

        // ISP - Violação (pode lançar NotImplementedException)
        SafeRun("ISP - Violação", () =>
        {
            var impressora = new SOLID.ISP.ImpressoraSimples_V();
            // Impressao OK
            impressora.Imprimir();
            // chamadas que podem lançar:
            try
            {
                impressora.Escanear();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine($"Exceção esperada ao escanear: {ex.Message}");
            }
            try
            {
                impressora.EnviarFax();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine($"Exceção esperada ao enviar fax: {ex.Message}");
            }
        });

        // ISP - Solução
        SafeRun("ISP - Solução", () =>
        {
            new SOLID.ISP.Impressora_S().Imprimir();
            new SOLID.ISP.Scanner_S().Escanear();
        });

        // DIP - Violação
        SafeRun("DIP - Violação", () =>
        {
            var serv = new SOLID.DIP.ServicoPedido_V();
            serv.CriarPedido();
        });

        // DIP - Solução
        SafeRun("DIP - Solução", () =>
        {
            var serv = new SOLID.DIP.ServicoPedido_S(new SOLID.DIP.RepositorioSQL_S());
            serv.CriarPedido();
        });

        Console.WriteLine("\n===== FIM DO TESTE =====");
    }

    static void SafeRun(string title, Action action)
    {
        Console.WriteLine($"\n--- {title} ---");
        try
        {
            action();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao executar {title}: {ex.GetType().Name} - {ex.Message}");
        }
    }
}

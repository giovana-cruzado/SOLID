namespace SOLID.ISP
{
    public interface IImpressora { void Imprimir(); }
    public interface IScanner { void Escanear(); }

    public class Impressora_S : IImpressora
    {
        public void Imprimir() => System.Console.WriteLine("[ISP - Solução] Imprimindo...");
    }

    public class Scanner_S : IScanner
    {
        public void Escanear() => System.Console.WriteLine("[ISP - Solução] Escaneando...");
    }
}

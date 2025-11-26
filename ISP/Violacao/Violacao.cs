namespace SOLID.ISP
{
    public interface IDispositivo_V
    {
        void Imprimir();
        void Escanear();
        void EnviarFax();
    }

    // Impressora simples é FORÇADA a implementar métodos que não usa
    public class ImpressoraSimples_V : IDispositivo_V
    {
        public void Imprimir() => System.Console.WriteLine("[ISP - Violação] Imprimindo...");
        public void Escanear() => throw new System.NotImplementedException();
        public void EnviarFax() => throw new System.NotImplementedException();
    }
}

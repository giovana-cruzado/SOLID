namespace SOLID.LSP
{
    public interface IForma
    {
        int Area();
    }

    public class Retangulo_S : IForma
    {
        public int Largura { get; set; }
        public int Altura { get; set; }
        public int Area() => Largura * Altura;
    }

    public class Quadrado_S : IForma
    {
        public int Lado { get; set; }
        public int Area() => Lado * Lado;
    }
}

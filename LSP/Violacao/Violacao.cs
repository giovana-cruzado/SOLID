namespace SOLID.LSP
{
    public class Retangulo_V
    {
        public virtual int Largura { get; set; }
        public virtual int Altura { get; set; }
        public int Area() => Largura * Altura;
    }

    public class Quadrado_V : Retangulo_V
    {
        // QUADRADO viola o comportamento esperado de RETÂNGULO
        public override int Largura { set { base.Largura = base.Altura = value; } }
        public override int Altura { set { base.Largura = base.Altura = value; } }
    }
}

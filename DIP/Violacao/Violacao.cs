namespace SOLID.DIP
{
    public class RepositorioSQL_V
    {
        public void Salvar(string dado)
        {
            System.Console.WriteLine("[DIP - Violação] Salvando no SQL...");
        }
    }

    public class ServicoPedido_V
    {
        private RepositorioSQL_V repo = new RepositorioSQL_V(); // depende de implementação concreta

        public void CriarPedido()
        {
            repo.Salvar("pedido criado");
        }
    }
}

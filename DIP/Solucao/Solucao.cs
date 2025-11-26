namespace SOLID.DIP
{
    public interface IRepositorio
    {
        void Salvar(string dado);
    }

    public class RepositorioSQL_S : IRepositorio
    {
        public void Salvar(string dado)
        {
            System.Console.WriteLine("[DIP - Solução] Salvando no SQL...");
        }
    }

    public class ServicoPedido_S
    {
        private readonly IRepositorio repo;

        public ServicoPedido_S(IRepositorio r)
        {
            repo = r;
        }

        public void CriarPedido()
        {
            repo.Salvar("pedido criado");
        }
    }
}

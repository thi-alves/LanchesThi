using LanchesThi.Models;

namespace LanchesThi.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }

    }
}

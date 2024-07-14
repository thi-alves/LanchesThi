using LanchesThi.Models;

namespace LanchesThi.Repositories.Interfaces
{
    public interface ILanchesRepository
    {
        IEnumerable <Lanche> Lanches { get; }   
        IEnumerable<Lanche> LanchesPreferidos { get; }

        Lanche GetLancheById(int lancheid);
    }
}

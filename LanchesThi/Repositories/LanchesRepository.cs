using LanchesThi.Data;
using LanchesThi.Models;
using LanchesThi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesThi.Repository
{
    public class LanchesRepository : ILanchesRepository
    {
        private readonly AppDbContext _context;

        public LanchesRepository(AppDbContext context)
        {
            _context = context;            
        }
        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c=> c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(
            p => p.IsLanchePreferido).Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheid) => _context.Lanches.FirstOrDefault(
            l => l.LancheId == lancheid);
    }
}

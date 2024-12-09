using DevoirCsharp.models;

namespace DevoirCsharp.Services.Impl
{
    public class ClasseService : IClasseService
    {
        private readonly ApplicationDbContext _context;

        public ClasseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Classe> ListerClasses()
        {
            return _context.Classes.ToList();
        }

        public Classe ObtenirClasse(int id)
        {
            return _context.Classes.Find(id);
        }
    }
}

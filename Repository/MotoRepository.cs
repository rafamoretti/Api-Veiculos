using ApiVeiculos.Context;
using ApiVeiculos.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiVeiculos.Repository
{
    public class MotoRepository
    {
        private readonly AppDbContext _context;

        public MotoRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Moto moto)
        {
            _context.Motos.Add(moto);
            Save();
        }

        public IEnumerable<Moto> GetAll()
        {
            return _context.Motos.AsNoTracking().ToList();
        }

        public Moto GetById(int id)
        {
            return _context.Motos.FirstOrDefault(moto => moto.MotoId == id);
        }

        public void Update(Moto moto)
        {
            _context.Entry(moto).State = EntityState.Modified;
            _context.Motos.Update(moto);
            Save();
        }

        public void Delete(int id)
        {
            var moto = this.GetById(id);
            _context.Motos.Remove(moto);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
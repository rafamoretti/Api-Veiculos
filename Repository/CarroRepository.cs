using ApiVeiculos.Context;
using ApiVeiculos.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiVeiculos.Repository
{
    public class CarroRepository
    {
        private readonly AppDbContext _context;

        public CarroRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Carro carro)
        {
            _context.Carros.Add(carro);
            Save();
        }

        public IEnumerable<Carro> GetAll()
        {
            return _context.Carros.AsNoTracking().ToList();
        }

        public Carro GetById(int id)
        {
            return _context.Carros.FirstOrDefault(carro => carro.CarroId == id);
        }

        public void Update(Carro Carro)
        {
            _context.Entry(Carro).State = EntityState.Modified;
            _context.Carros.Update(Carro);
            Save();
        }

        public void Delete(int id)
        {
            var carro = this.GetById(id);
            _context.Carros.Remove(carro);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
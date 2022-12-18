using ApiVeiculos.Context;
using ApiVeiculos.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiVeiculos.Repository
{
    public class CarroRepository
    {
        private readonly AppDbContext _context;

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
        }

        public void Delete(int id)
        {
            var Carro = this.GetById(id);
            _context.Carros.Remove(Carro);
        }
    }
}
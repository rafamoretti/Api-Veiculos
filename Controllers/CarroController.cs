using ApiVeiculos.Context;
using ApiVeiculos.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiVeiculos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CarroController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Carro>> Get()
        {
            var carros = _context.Carros.ToList();

            if (carros == null || carros.Count == 0)
                BadRequest();

            return Ok(carros);
        }

        [HttpPost]
        public ActionResult Post(Carro carro)
        {
            _context.Carros.Add(carro);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public ActionResult Put(Carro carro)
        {
            _context.Carros.Entry(carro).State = EntityState.Modified;
            _context.Carros.Update(carro);
            _context.SaveChanges();

            return Ok(carro);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var carro = _context.Carros.FirstOrDefault(carro => carro.CarroId == id);

            if (carro == null)
                return BadRequest();

            _context.Carros.Remove(carro);
            _context.SaveChanges();

            return Ok(carro);
        }
    }
}
using ApiVeiculos.Context;
using ApiVeiculos.Model;
using ApiVeiculos.Repository;
using ApiVeiculos.Services;
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
            var repository = new CarroRepository(_context);
            var carros = repository.GetAll();

            if (carros == null || carros.Count() == 0)
                return NotFound("Nenhum carro encontrado");

            return Ok(carros);
        }

        [HttpGet("quilometros/{id:int}")]
        public ActionResult GetQuilometros(int id)
        {
            var service = new VeiculosMotorizadosService();
            var repository = new CarroRepository(_context);

            var carro = repository.GetById(id);

            var quilometros = new 
            {
                Km = service.VerificaQuilometragemPorLitro(carro),
            };
            
            return Ok(quilometros);
        }

        [HttpGet("carro/{id:int}")]
        public ActionResult GetById(int id)
        {
            var repository = new CarroRepository(_context);
            var carro = repository.GetById(id);

            if (carro == null)
                return NotFound("Nenhum carro encontrado");

            return Ok(carro);
        }

        [HttpPost]
        public ActionResult Post(Carro carro)
        {
            var repository = new CarroRepository(_context);
            repository.Add(carro);

            return Ok();
        }

        [HttpPut]
        public ActionResult Put(Carro carro)
        {
            var repository = new CarroRepository(_context);
            repository.Update(carro);

            return Ok(carro);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var repository = new CarroRepository(_context);
            var carro = repository.GetById(id);
            
            repository.Delete(carro);

            return Ok();
        }
    }
}
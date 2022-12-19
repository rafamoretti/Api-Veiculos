using ApiVeiculos.Context;
using ApiVeiculos.Model;
using ApiVeiculos.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiVeiculos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MotoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Moto>> Get()
        {
            var repository = new MotoRepository(_context);
            var motos = repository.GetAll();

            if (motos == null || motos.Count() == 0)
                return NotFound("Nenhuma moto encontrado");

            return Ok(motos);
        }

        [HttpGet("moto/{id:int}")]
        public ActionResult GetById(int id)
        {
            var repository = new MotoRepository(_context);
            var moto = repository.GetById(id);

            if (moto == null)
                return NotFound("Nenhuma moto encontrado");

            return Ok(moto);
        }

        [HttpPost]
        public ActionResult Post(Moto moto)
        {
            var repository = new MotoRepository(_context);
            repository.Add(moto);

            return Ok();
        }

        [HttpPut]
        public ActionResult Put(Moto moto)
        {
            var repository = new MotoRepository(_context);
            repository.Update(moto);

            return Ok(moto);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var repository = new MotoRepository(_context);
            repository.Delete(id);

            return Ok();
        }
    }
}
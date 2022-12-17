using ApiVeiculos.Context;
using ApiVeiculos.Model;
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
            var motos = _context.Motos.ToList();

            if (motos == null || motos.Count == 0)
                BadRequest();

            return Ok(motos);
        }

        [HttpPost]
        public ActionResult Post(Moto moto)
        {
            _context.Motos.Add(moto);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public ActionResult Put(Moto moto)
        {
            _context.Motos.Entry(moto).State = EntityState.Modified;
            _context.Motos.Update(moto);
            _context.SaveChanges();

            return Ok(moto);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var moto = _context.Motos.FirstOrDefault(moto => moto.MotoId == id);

            if (moto == null)
                return BadRequest();

            _context.Motos.Remove(moto);
            _context.SaveChanges();

            return Ok(moto);
        }
    }
}
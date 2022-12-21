using ApiVeiculos.Context;
using ApiVeiculos.Model;
using ApiVeiculos.Repository;
using ApiVeiculos.Repository.Interfaces;
using ApiVeiculos.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiVeiculos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotoController : ControllerBase
    {
        private readonly IMotoRepository _repository;
        private readonly IVeiculosMotorizadosService _veiculosMotorizadosService;
        private readonly IVeiculosRegistraveisService _veiculosRegistraveisService;

        public MotoController(IMotoRepository repository, IVeiculosMotorizadosService veiculosMotorizadosService, IVeiculosRegistraveisService veiculosRegistraveisService)
        {
            _repository = repository;
            _veiculosMotorizadosService = veiculosMotorizadosService;
            _veiculosRegistraveisService = veiculosRegistraveisService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Moto>> Get()
        {
            var motos = _repository.GetAll();

            if (motos == null || motos.Count() == 0)
                return NotFound("Nenhuma moto encontrado");

            return Ok(motos);
        }

        [HttpGet("moto/{id:int}")]
        public ActionResult GetById(int id)
        {
            var moto = _repository.GetById(id);

            if (moto == null)
                return NotFound("Nenhuma moto encontrado");

            return Ok(moto);
        }

        [HttpGet("quilometros/{id:int}")]
        public ActionResult GetQuilometros(int id)
        {
            var moto = _repository.GetById(id);

            var quilometros = new
            {
                Km = _veiculosMotorizadosService.VerificaQuilometragemPorLitro(moto),
            };

            return Ok(quilometros);
        }

        [HttpGet("revisao/{id:int}")]
        public ActionResult GetRevisao(int id)
        {
            var moto = _repository.GetById(id);

            var revisao = new
            {
                verificacaoRevisao = _veiculosRegistraveisService.VerificaRevisao(moto),
            };

            return Ok(revisao);
        }

        [HttpPost]
        public ActionResult Post(Moto moto)
        {
            _repository.Add(moto);

            return Ok();
        }

        [HttpPut]
        public ActionResult Put(Moto moto)
        {
            _repository.Update(moto);

            return Ok(moto);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var moto = _repository.GetById(id);

            _repository.Delete(moto);

            return Ok();
        }
    }
}
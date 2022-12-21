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
    public class CarroController : ControllerBase
    {
        private readonly ICarroRepository _repository;
        private readonly IVeiculosMotorizadosService _veiculosMotorizadosService;
        private readonly IVeiculosRegistraveisService _veiculosRegistraveisService;

        public CarroController(ICarroRepository repository, IVeiculosMotorizadosService veiculosMotorizadosService, IVeiculosRegistraveisService veiculosRegistraveisService)
        {
            _repository = repository;
            _veiculosMotorizadosService = veiculosMotorizadosService;
            _veiculosRegistraveisService = veiculosRegistraveisService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Carro>> Get()
        {
            var carros = _repository.GetAll();

            if (carros == null || carros.Count() == 0)
                return NotFound("Nenhum carro encontrado");

            return Ok(carros);
        }

        [HttpGet("quilometros/{id:int}")]
        public ActionResult GetQuilometros(int id)
        {
            var carro = _repository.GetById(id);

            var quilometros = new 
            {
                Km = _veiculosMotorizadosService.VerificaQuilometragemPorLitro(carro),
            };
            
            return Ok(quilometros);
        }

        [HttpGet("revisao/{id:int}")]
        public ActionResult GetRevisao(int id)
        {
            var carro = _repository.GetById(id);

            var revisao = new
            {
                verificacaoRevisao = _veiculosRegistraveisService.VerificaRevisao(carro),
            };

            return Ok(revisao);
        }

        [HttpGet("lugares/{id:int}")]
        public ActionResult GetQuantidadeDeLugares(int id)
        {
            var lugares = _repository.GetQuantidadeDeLugares(id);

            return Ok(lugares);
        }

        [HttpGet("carro/{id:int}")]
        public ActionResult GetById(int id)
        {
            var carro = _repository.GetById(id);

            if (carro == null)
                return NotFound("Nenhum carro encontrado");

            return Ok(carro);
        }

        [HttpPost]
        public ActionResult Post(Carro carro)
        {
            _repository.Add(carro);
            return Ok();
        }

        [HttpPut]
        public ActionResult Put(Carro carro)
        {
            _repository.Update(carro);

            return Ok(carro);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var carro = _repository.GetById(id);
            _repository.Delete(carro);

            return Ok();
        }
    }
}
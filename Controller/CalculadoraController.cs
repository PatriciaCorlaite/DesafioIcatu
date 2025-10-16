using Microsoft.AspNetCore.Mvc;
using Desafio.DTOs;
using Desafio.Services;

namespace Desafio.Controllers
{
    [ApiController]
    [Route("api")]
    public class CalculadoraController : ControllerBase
    {
        private readonly IRandomService _randomService;
        private readonly ICalculadoraService _calculadoraService;

        public CalculadoraController(IRandomService randomService, ICalculadoraService calculadoraService)
        {
            _randomService = randomService;
            _calculadoraService = calculadoraService;
        }

        // GET /api/random
        [HttpGet("random")]
        public IActionResult GetRandom()
        {
            var numero = _randomService.GerarNumeroAleatorio();
            return Ok(new { NumeroAleatorio = numero });
        }

        // POST /api/calcular
        [HttpPost("calcular")]
        public IActionResult Calcular([FromBody] OperacaoDTO dto)
        {
            try
            {
                var resultado = _calculadoraService.Calcular(dto);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.Message });
            }
        }
    }
}
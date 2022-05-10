using Microsoft.AspNetCore.Mvc;
namespace CalculadoraAPI.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        [HttpGet("soma")]
        public IActionResult SomaAPI(int primeiroNumero, int segundoNumero)
        {
            if (primeiroNumero >= 1000 || segundoNumero >= 1000)
            {
                return BadRequest("Os números não podem ser maiores que 999");
            }
            else if (primeiroNumero == 0 || segundoNumero == 0)
            {
                return BadRequest("Os números não podem ser iguais a 0");
            }
            return Ok($"O resultado da soma é {primeiroNumero + segundoNumero}");
        }

        [HttpGet("subtração")]
        public IActionResult SubtracaoAPI(int primeiroNumero, int segundoNumero)
        {
            if (primeiroNumero >= 1000 || segundoNumero >= 1000)
            {
                return BadRequest("Os números não podem ser maiores que 999");
            }
            else if (primeiroNumero == 0 || segundoNumero == 0)
            {
                return BadRequest("Os números não podem ser iguais a 0");
            }
            return Ok($"O resultado da subtração é {primeiroNumero - segundoNumero}");
        }

        [HttpGet("multiplicação")]
        public IActionResult MultiplicaçãoAPI(int primeiroNumero, int segundoNumero)
        {
            if (primeiroNumero >= 1000 || segundoNumero >= 1000)
            {
                return BadRequest("Os números não podem ser maiores que 999");
            }
            else if (primeiroNumero <= 0 || segundoNumero <= 0)
            {
                return BadRequest("Os números não podem ser iguais nem menores que 0");
            }
            return Ok($"O resultado da multiplicação é {primeiroNumero * segundoNumero}");
        }

        [HttpGet("divisão")]
        public IActionResult DivisãoAPI(int primeiroNumero, int segundoNumero)
        {
            if (primeiroNumero >= 1000 || segundoNumero >= 1000)
            {
                return BadRequest("Os números não podem ser maiores que 999");
            }
            else if (primeiroNumero <= 0 || segundoNumero <= 0)
            {
                return BadRequest("Os números não podem ser iguais nem menores que 0");
            }
            return Ok($"O resultado da divisão é {primeiroNumero * segundoNumero}");
        }
    }
}
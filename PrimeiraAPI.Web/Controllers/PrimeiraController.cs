using Microsoft.AspNetCore.Mvc;
namespace PrimeiraAPI.Web.Controllers
{
    [ApiController]
    [Route("MinhaController")]
    public class PrimeiraController : ControllerBase
    {
        [HttpGet]
        public string PrimeiraAPI(){
            return "Teste";
        }
    
    
        [HttpGet("segundaAPI")]
        public string SegundaAPI(){
            return "Teste";
        }

        [HttpGet("TerceiraAPI")]
        public IActionResult OutraAPI(int entrada){
            if(entrada == 1){
                return BadRequest("1 não é uma entrada válida");
            }
            return Ok("Dado inserido foi:" + entrada);
        }
    }
}
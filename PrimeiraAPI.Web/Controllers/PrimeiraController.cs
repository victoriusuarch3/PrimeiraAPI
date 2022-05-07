using Microsoft.AspNetCore.Mvc;
namespace PrimeiraAPI.Web.Controllers
{
    [ApiController]
    [Route("MinhaController")]
    public class PrimeiraController
    {
        [HttpGet]
        public string PrimeiraAPI(){
            return "Teste";
        }
    
    
        [HttpGet("segundaAPI")]
        public string SegundaAPI(){
            return "Teste";
        }
    }
}
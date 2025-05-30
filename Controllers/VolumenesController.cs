using Microsoft.AspNetCore.Mvc;

namespace CalculadoraVolumenes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VolumenesController : ControllerBase
    {
        [HttpGet("cubo")]
        public IActionResult VolumenCubo(double lado)
        {
            double volumen = Math.Pow(lado, 3);
            return Ok(new { figura = "Cubo", volumen });
        }

        [HttpGet("esfera")]
        public IActionResult VolumenEsfera(double radio)
        {
            double volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
            return Ok(new { figura = "Esfera", volumen });
        }

        [HttpGet("cilindro")]
        public IActionResult VolumenCilindro(double radio, double altura)
        {
            double volumen = Math.PI * Math.Pow(radio, 2) * altura;
            return Ok(new { figura = "Cilindro", volumen });
        }

        [HttpGet("cono")]
        public IActionResult VolumenCono(double radio, double altura)
        {
            double volumen = (1.0 / 3.0) * Math.PI * Math.Pow(radio, 2) * altura;
            return Ok(new { figura = "Cono", volumen });
        }
    }
} 
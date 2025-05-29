using Microsoft.AspNetCore.Mvc;

namespace CalculadoraAreas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AreasController : ControllerBase
    {
        [HttpGet("rectangulo")]
        public IActionResult AreaRectangulo(double bas, double altura)
        {
            double area = bas * altura;
            return Ok(new { figura = "Rectángulo", area });
        }

        [HttpGet("cuadrado")]
        public IActionResult AreaCuadrado(double lado)
        {
            double area = lado * lado;
            return Ok(new { figura = "Cuadrado", area });
        }

        [HttpGet("triangulo")]
        public IActionResult AreaTriangulo(double bas, double altura)
        {
            double area = (bas * altura) / 2;
            return Ok(new { figura = "Triángulo", area });
        }

        [HttpGet("circulo")]
        public IActionResult AreaCirculo(double radio)
        {
            double area = Math.PI * radio * radio;
            return Ok(new { figura = "Círculo", area });
        }
    }
}
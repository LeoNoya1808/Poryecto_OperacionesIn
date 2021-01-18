using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web_Operaciones.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraController : Controller
    {
        [HttpGet]
        [Route("Suma")]
        public int suma(int num1, int num2)
        {
            return num1 + num2;
        }
        [HttpPost]
        [Route("Suma")]
        public int sumar([FromHeader] int num1, [FromHeader] int num2)
        {
            return num1 + num2;
        }
        [HttpGet]
        [Route("Resta")]
        public int RestaGet(int num1, int num2)
        {
            return num1 - num2;
        }
        [HttpPost]
        [Route("Resta")]
        public int RestaPost([FromHeader] int num1, [FromHeader] int num2)
        {
            return num1 - num2;
        }

    }
}

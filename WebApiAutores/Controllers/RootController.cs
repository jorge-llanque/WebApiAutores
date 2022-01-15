using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAutores.DTOs;

namespace WebApiAutores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RootController : ControllerBase
    {
        [HttpGet(Name = "ObtenerRoot")]
        public ActionResult<IEnumerable<DatoHATEOAS>> Get()
        {
            var datosHateoas = new List<DatoHATEOAS>();

            datosHateoas.Add(new DatoHATEOAS(enlace: Url.Link("ObtenerRoot", new { }), descripcion: "self", metodo: "GET"));

            return datosHateoas;
        }
    }
}

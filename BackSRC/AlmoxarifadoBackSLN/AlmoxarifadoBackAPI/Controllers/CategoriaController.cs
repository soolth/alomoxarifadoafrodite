using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly List<Categoria> _categorias;

        public CategoriaController()
        {
            _categorias = new List<Categoria>()
            {
                new Categoria()
                {
                    Codigo = 1,
                    Descricao ="Bebidas"
                },
                new Categoria()
                {
                    Codigo = 2,
                    Descricao ="Alimento"
                }
            };
        }

        [HttpGet("/lista")]
        public IActionResult listaCategorias()
        {
            return Ok(_categorias);
        }

        [HttpPost("/categoria")]
        public IActionResult listaCategorias(CategoriaDTO categoria)
        {
            return Ok(_categorias.Where(x=>x.Codigo==categoria.Codigo));
        }
    }   
}

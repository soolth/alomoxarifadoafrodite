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

        [HttpPost("/criarcategoria")]
        public IActionResult criarCategoria(Categoria categoria)
        {

            var novaCategoria = new Categoria()
            {
                Codigo = categoria.Codigo,
                Descricao = categoria.Descricao
            };
            _categorias.Add(novaCategoria);
            return Ok("Cadastro com Sucesso");
        }

        [HttpDelete("/removercategoria")]
        public IActionResult removerCategorias(CategoriaDTO categoria)
        {
            var itemPesquisado = _categorias.FirstOrDefault(x => x.Codigo == categoria.Codigo);

            if (itemPesquisado != null)
            {
                _categorias.Remove(itemPesquisado);
                return Ok("Removido com sucesso");
            }
            else
            {
                return Ok("Produdo não localizado");
            }

            
        }



    }
}

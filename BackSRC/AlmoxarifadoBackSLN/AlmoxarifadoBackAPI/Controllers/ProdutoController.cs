using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio_pro;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepositorio _db;
        public ProdutoController(IProdutoRepositorio db)
        {
            _db =db;
      
        }

        [HttpGet("/listaproduto")]
        public IActionResult listaProduto()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/Produto")]
        public IActionResult listaProduto(ProdutoDTO produto)
        {
            return Ok(_db.GetAll().Where(x=>x.Codigo==produto.Codigo));
        }

        [HttpPost("/criarproduto")]
        public IActionResult criarProduto(ProdutoCadastroDTO produto)
        {

            var novaProduto = new Produto()
            {               
                Descricao = produto.Descricao
            };
            //_categorias.Add(novaCategoria);
            _db.Add(novaProduto);
            return Ok("Cadastro com Sucesso");
        }

        



    }
}

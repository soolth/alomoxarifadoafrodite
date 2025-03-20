using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SaidaController : ControllerBase
    {
        private readonly ISaidaRepositorio _db;
        public SaidaController(ISaidaRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/saida")]
        public IActionResult listasaida()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/listasaidaFiltro")]
        public IActionResult listasaidaFiltro(SaidaDTO saida)
        {
            return Ok(_db.GetAll().Where(x=>x.Codigo==saida.Codigo));
        }

        [HttpPost("/criarSaida")]
        public IActionResult criarEntrada(SaidaCadastroDTO saida)
        {

            var novaSaida = new Saida()
            {               
                Descricao = saida.Descricao
            };
          
            _db.Add(novaSaida);
            return Ok("Cadastro com Sucesso");
        }



    }
}

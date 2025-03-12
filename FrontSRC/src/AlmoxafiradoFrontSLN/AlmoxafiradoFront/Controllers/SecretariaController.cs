using AlmoxafiradoFront.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;

namespace AlmoxafiradoFront.Controllers
{
    public class SecretariaController : Controller
    {
        public IActionResult Index()
        {
            var url = "https://localhost:44366/listaFornecedor";
            List<FornecedorDTO> fornecedo = new List<FornecedorDTO>();
            using HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                string json = response.Content.ReadAsStringAsync().Result;
                fornecedo = JsonSerializer.Deserialize<List<FornecedorDTO>>(json);
                ViewBag.Produtos = fornecedo;


            }
            catch (Exception)
            {
                return View();

            }

            return View();
        }
    }
}
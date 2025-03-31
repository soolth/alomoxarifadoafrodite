﻿using AlmoxafiradoFront.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlmoxafiradoFront.Controllers
{
    public class CategoriaController : Controller
    {
        public object JsonSerializar { get; private set; }

        public IActionResult Index()
        {
            var url = "https://localhost:44366/lista";
            List<CategoriaDTO> categorias = new List<CategoriaDTO>();
            using HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                string json = response.Content.ReadAsStringAsync().Result;
                categorias = JsonSerializer.Deserialize<List<CategoriaDTO>>(json);
                ViewBag.Categorias = categorias;


            }
            catch (Exception)
            {
                return View();

            }

            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(string descricao)
        {
            var url = "https://localhost.44366/criarcategoria";
            using HttpClient client = new HttpClient();
            try
            {
                var categoriaNova = new CategoriaNovaDTO { descricao = descricao };
                var categoriaSerializada = JsonSerializer.Serialize<CategoriaNovaDTO>(categoriaNova);
                var jsonContent = new StringContext(categoriaSerializada, Encoding.UTF8, "application/json");

                HttpResponseMessage response = client.PostAsync(url, jsonContent).Result;
                response.EnsureSuccessStatusCode();
            }
            catch (Exception) {
                return View();
            }
            return RedirectToAction("Index");
                }
    }
}
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnalisadorFotos.Services;
using System.Text.Encodings.Web;
using Newtonsoft.Json;

namespace AnalisadorFotos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string imagem)
        {
            var analisador = new VisionAPI();
            var retorno = analisador.FazAnalise(imagem).Result;

            ViewData["imagem"] = imagem;
            ViewData["analise"] = retorno;

            return View();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicios.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercicios.Controllers
{
    public class RepeticaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult RepeticaoWhile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RepeticaoWhile(Tabuada tabuada)
        {
            tabuada.Tipo = TipoOperador.While;
            tabuada.Calcular();
            return View(tabuada);
        }

        [HttpGet]
        public IActionResult RepeticaoFor()
        {
            return View();
        }

    }
}
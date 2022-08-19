using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicios.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercicios.Controllers
{
    public class CondicionaisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CondicionalIf()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CondicionalIf(Partida partida)
        {
            return View(partida);
        }

        [HttpGet]
        public IActionResult CondicionalSwitch()
        {
            return View();
        }

        [HttpPost]
	    public IActionResult CondicionalSwitch(Pedido pedido)
	    {
		    return View(pedido);
	    }

        [HttpGet]
        public IActionResult RepeticaoDo()
        {
            return View();
        }

        	[HttpPost]
        public IActionResult RepeticaoDo(Tabuada tabuada)
        {
            tabuada.Tipo = TipoOperador.Repeat;
            tabuada.Calcular();
            return View(tabuada);
        }



    }
    
}

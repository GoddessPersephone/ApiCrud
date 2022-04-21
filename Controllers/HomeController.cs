using ApiCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        { 
            return View();
        }

        public IActionResult Privacy()
        {
            VagasAbertas vaga = new VagasAbertas();

            vaga.vaga1 = "Analista de Dados";
            vaga.vaga2 = "Desenvolvedor Back-End";
            vaga.vaga3 = "Desenvolvedor Front-End";
            vaga.vaga4 = "Desenvolvedor FullStak";
            vaga.vaga5 = "Desenvolvedor Mobile";
            vaga.vaga6 = "Designer";
            vaga.vaga7 = "Engenheiro de Software";
            vaga.vaga8 = "Gerente de Projetos";
           
            return View(vaga);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

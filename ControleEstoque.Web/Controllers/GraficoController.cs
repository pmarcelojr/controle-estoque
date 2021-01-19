using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ControleEstoque.Web.Models;

namespace ControleEstoque.Web.Controllers
{
    public class GraficoController : Controller
    {
        private readonly ILogger<GraficoController> _logger;

        public GraficoController(ILogger<GraficoController> logger)
        {
            _logger = logger;
        }


        public IActionResult PerdaMes()
        {
            return View();
        }

        public IActionResult EntradaSaidaMes()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
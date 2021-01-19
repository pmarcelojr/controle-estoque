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
    public class RelatorioController : Controller
    {
        private readonly ILogger<RelatorioController> _logger;

        public RelatorioController(ILogger<RelatorioController> logger)
        {
            _logger = logger;
        }


        public IActionResult PosicaoEstoque()
        {
            return View();
        }

        public IActionResult Ressuprimento()
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
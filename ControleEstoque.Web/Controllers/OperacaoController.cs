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
    public class OperacaoController : Controller
    {
        private readonly ILogger<OperacaoController> _logger;

        public OperacaoController(ILogger<OperacaoController> logger)
        {
            _logger = logger;
        }


        public IActionResult EntradaEstoque()
        {
            return View();
        }

        public IActionResult SaidaEstoque()
        {
            return View();
        }
        public IActionResult LancPerdaProduto()
        {
            return View();
        }
        public IActionResult Inventario()
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
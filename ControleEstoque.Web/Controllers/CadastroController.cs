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
    public class CadastroController : Controller
    {
        private readonly ILogger<CadastroController> _logger;

        public CadastroController(ILogger<CadastroController> logger)
        {
            _logger = logger;
        }


        public IActionResult GrupoProduto()
        {
            return View();
        }

        public IActionResult MarcaProduto()
        {
            return View();
        }
        public IActionResult LocalProduto()
        {
            return View();
        }
        public IActionResult UnidadeMedida()
        {
            return View();
        }
        public IActionResult Produto()
        {
            return View();
        }
        public IActionResult Fornecedor()
        {
            return View();
        }
        public IActionResult Paises()
        {
            return View();
        }
        public IActionResult Estados()
        {
            return View();
        }
        public IActionResult Cidades()
        {
            return View();
        }
        public IActionResult PerfilUsuario()
        {
            return View();
        }
        public IActionResult Usuario()
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
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto_Imperio.Models;
using Projeto_Imperio.Context;

namespace Projeto_Imperio.Controllers
{
    [Route("[controller]")]
    public class FuncionarioController : Controller
    {
        private readonly FuncionarioContext _context;
    
        public FuncionarioController(FuncionarioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var funcionario = _context.Funcionarios.ToList();
            return View(funcionario);
        }
    }
}
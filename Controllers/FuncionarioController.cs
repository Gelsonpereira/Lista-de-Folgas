using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto_Imperio.Models;
using Projeto_Imperio.Context;
using AspNetCoreGeneratedDocument;
using System.Collections;
using Microsoft.EntityFrameworkCore;

namespace Projeto_Imperio.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly FuncionarioContext _context;
    
        public FuncionarioController(FuncionarioContext context)
        {
            _context = context;
        }
        
        [HttpGet("Incio")]
        public IActionResult Index()
{
            var funcionarios = _context.Funcionarios.ToList();
            return View(funcionarios);
}
        [HttpGet]
        public IActionResult Criar() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(EscalaFuncionario funcionario)
        {
            if (ModelState.IsValid)
            {
                _context.Funcionarios.Add(funcionario);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(funcionario);
        }
        public IActionResult Editar(int id)
        {
            var funcionario = _context.Funcionarios.Find(id);

            if (funcionario == null)
                   return NotFound();

                return View(funcionario); 
        }
        
        [HttpPost]
        public IActionResult Editar(EscalaFuncionario funcionario)
        {
           var escalaFuncionario = _context.Funcionarios.Find(funcionario.Id);

           escalaFuncionario.Nome = funcionario.Nome;
           escalaFuncionario.Mes = funcionario.Mes;
           escalaFuncionario.Data = funcionario.Data;

           _context.Funcionarios.Update(escalaFuncionario);
           _context.SaveChanges();

           return RedirectToAction(nameof(Index));
           
        }
        public IActionResult Deletar(EscalaFuncionario funcionario)
        {   
            var escalaFuncionario = _context.Funcionarios.Find(funcionario);

             if (funcionario == null)
                   return NotFound();

                return View(escalaFuncionario); 
        }

        [HttpDelete]
        public IActionResult Deletar(int id)
        {
            var funcionario = _context.Funcionarios.Find(id);

            _context.Funcionarios.Remove(funcionario);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }   

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_Imperio.Models;

namespace Projeto_Imperio.Context
{
    public class FuncionarioContext : DbContext
    {
        public FuncionarioContext(DbContextOptions<FuncionarioContext> options) : base(options)
        {
        }

        public DbSet<EscalaFuncionario> Funcionarios { get; set; }
    }

}
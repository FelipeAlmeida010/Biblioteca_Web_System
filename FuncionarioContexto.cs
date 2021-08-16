using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca_Web_System.Models;

namespace Biblioteca_Web_System.Models
{
    public class FuncionarioContexto : DbContext
    {
        public FuncionarioContexto(DbContextOptions<FuncionarioContexto> options) : base(options)

        {

        }

        public DbSet<Funcionario> Funcionarios { get; set; }

        public DbSet<Biblioteca_Web_System.Models.Locacao> Locacao { get; set; }
    }






}


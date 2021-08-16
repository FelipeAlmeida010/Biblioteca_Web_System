using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca_Web_System.Models
{
    public class PessoaContexto : DbContext
    {

        public PessoaContexto(DbContextOptions<PessoaContexto> options) : base(options)

        {

        }

        public DbSet<Pessoa>Pessoas { get; set; }
    }






}


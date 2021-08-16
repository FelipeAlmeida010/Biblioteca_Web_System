using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca_Web_System.Models
{
    public class LivroContexto : DbContext
    {
       public LivroContexto(DbContextOptions<LivroContexto> options) : base(options)

        {

        }

        public DbSet<Livro> Livros { get; set; }
    }
}

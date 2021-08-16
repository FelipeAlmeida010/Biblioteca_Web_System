using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca_Web_System.Models
{
    public class CategoriaContexto : DbContext
    {

        public CategoriaContexto(DbContextOptions<CategoriaContexto> options) : base(options)

        {

        }

        public DbSet<Categoria>Categorias { get; set; }
    }






}


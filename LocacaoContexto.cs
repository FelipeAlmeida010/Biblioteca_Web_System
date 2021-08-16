using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca_Web_System.Models
{
    public class LocacaoContexto : DbContext
    {

        public LocacaoContexto(DbContextOptions<LocacaoContexto> options) : base(options)

        {

        }

        public DbSet<Locacao>Locacoes { get; set; }
    }






}







  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca_Web_System.Models
{
    public class InicializaCategoriaDB
    {

        public static void Initialize(CategoriaContexto context)
        {
            context.Database.EnsureCreated();

            //Procurando por Categorias
            if (context.Categorias.Any())
            {
                return;
                //BD alimentado

            }
            var categorias = new Categoria[]
            {

                new Categoria { Nome = "Orgulho e Preconceito",Ativo = true },
                new Categoria { Nome = "George Orwell",Ativo = true },
                new Categoria { Nome = "Dom Quixote de la Mancha",Ativo = false},
                new Categoria { Nome = "O Pequeno Príncipe",Ativo = true },
                new Categoria { Nome = "Dom Casmurro ",Ativo = false },
                new Categoria { Nome = "O Bandolim do Capitão Corelli ",Ativo = false },
            };
            foreach (Categoria p in categorias)
            {
                context.Categorias.Add(p);
            }
            context.SaveChanges();
        }

    }
}

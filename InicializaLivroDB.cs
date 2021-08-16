using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca_Web_System.Models
{
    public static class InicializaLivroDB
    {
        public static void Initialize(LivroContexto context)
        {
            context.Database.EnsureCreated();

            //Procurando por livros
            if (context.Livros.Any())
            {
                return;
                //BD alimentado

            }
            var livros = new Livro[]
            {

                new Livro { Titulo = "Orgulho e Preconceito", Autor = "Jane Austen", Descrição = "Quando Elizabeth Bennett conhece o senhor Darcy, de início eles se odeiam.", DataPublicacao = 1813 },
                new Livro { Titulo = "George Orwell", Autor = "George Orwell", Descrição = "Em um país controlado por um regime totalitário, um homem vai se rebelar contra o siatema", DataPublicacao = 1984 },
                new Livro { Titulo = "Dom Quixote de la Mancha", Autor = "Miguel de Cervantes", Descrição = "Um dos maiores clássicos da literatura espanhola, Dom Quixote conta a história de um cavaleiro que leu demasiados romances e enlouqueceu", DataPublicacao = 1605 },
                new Livro { Titulo = "O Pequeno Príncipe", Autor = "Antoine de Saint-Exupéry", Descrição = "O Pequeno Príncipe analisa questões profundas sobre a vida humana.", DataPublicacao = 1943 },
                new Livro { Titulo = "Dom Casmurro ", Autor = "Machado de Assis", Descrição = "Bento se apaixona e casa com uma mulher pobre chamada Capitu, mas começa a desconfiar de sua infidelidade.", DataPublicacao = 1999 },
                new Livro { Titulo = "O Bandolim do Capitão Corelli ", Autor = "Louis de Bernières", Descrição = " o capitão Corelli vai desafiar seus sentimentos. Um livro muito invulgar e interessante.", DataPublicacao = 2001 },
            };
            foreach (Livro p in livros)
            {
                context.Livros.Add(p);
            }
            context.SaveChanges();
        }
    }
}

            
             
            
        
















    


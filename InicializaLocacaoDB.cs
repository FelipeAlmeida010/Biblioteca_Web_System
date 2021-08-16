using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca_Web_System.Models
{
    public class InicializaLocacaoDB
    {


        public static void Initialize(LocacaoContexto context)
        {
            context.Database.EnsureCreated();

            //Procurando por Locacao
            if (context.Locacoes.Any())
            {
                return;
                //BD alimentado

            }
            var locacoes = new Locacao[]
            {

                new Locacao{DataLocação = 19/10/21,DataEntrega = 19/11/21},
                new Locacao{DataLocação = 20/10/21,DataEntrega = 19/11/21 },
                new Locacao{DataLocação = 21/10/21,DataEntrega = 19/11/21 },
                new Locacao{DataLocação = 22/10/21,DataEntrega = 19/11/21 },
                new Locacao{DataLocação = 23/10/21,DataEntrega = 19/11/21 },

            };
            foreach (Locacao p in locacoes)
            {
                context.Locacoes.Add(p);
            }
            context.SaveChanges();
        }





















    }
}

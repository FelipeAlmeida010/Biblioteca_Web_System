using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca_Web_System.Models
{
    public class InicializaPessoaDB
    {

        public static void Initialize(PessoaContexto context)
        {
            context.Database.EnsureCreated();

            //Procurando por Pessoass
            if (context.Pessoas.Any())
            {
                return;
                //BD alimentado

            }
            var pessoas = new Pessoa[]
            {

                
                new Pessoa { Nome = "Usuario1",DataNascimento = 10/04/97, CPF = 098-764-543-63, Email ="Usuario1@gmail.com",Endereço = "Rua torta-29" },
                new Pessoa { Nome = "Usuario2",DataNascimento = 10/04/96, CPF = 098-764-543-64, Email ="Usuario2@gmail.com",Endereço = "Rua torta-30" },
                new Pessoa { Nome = "Usuario3",DataNascimento = 10/04/95, CPF = 098-764-543-65, Email ="Usuario3@gmail.com",Endereço = "Rua torta-31" },
                new Pessoa { Nome = "Usuario4",DataNascimento = 10/04/94, CPF = 098-764-543-66, Email ="Usuario4@gmail.com",Endereço = "Rua torta-32" },
                new Pessoa { Nome = "Usuario5",DataNascimento = 10/04/93, CPF = 098-764-543-67, Email ="Usuario5@gmail.com",Endereço = "Rua torta-33" },
                new Pessoa { Nome = "Usuario6",DataNascimento = 10/04/92, CPF = 098-764-543-68, Email ="Usuario6@gmail.com",Endereço = "Rua torta-34" },
                new Pessoa { Nome = "Usuario7",DataNascimento = 10/04/91, CPF = 098-764-543-69, Email ="Usuario7@gmail.com",Endereço = "Rua torta-35" },
                new Pessoa { Nome = "Usuario8",DataNascimento = 10/04/90, CPF = 098-764-543-70, Email ="Usuario8@gmail.com",Endereço = "Rua torta-36" },
                new Pessoa { Nome = "Usuario9",DataNascimento = 10/04/89, CPF = 098-764-543-71, Email ="Usuario9@gmail.com",Endereço = "Rua torta-37" },
                new Pessoa { Nome = "Usuario10",DataNascimento = 10/04/88, CPF = 098-764-543-72, Email ="Usuario10@gmail.com",Endereço ="Rua torta-38" },

            };
            foreach (Pessoa p in pessoas)
            {
                context.Pessoas.Add(p);
            }
            context.SaveChanges();
        }
























    }
}

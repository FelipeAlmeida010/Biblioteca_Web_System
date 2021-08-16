using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Biblioteca_Web_System.Models
{
    public class InicializaFuncionarioDB
    {
        
        public static void Initialize(FuncionarioContexto context)
        {
            context.Database.EnsureCreated();

            //Procurando por Funcionarios
            if (context.Funcionarios.Any())
            {
                return;
                //BD alimentado

            }
            var funcionarios = new Funcionario[]
            {

                new Funcionario { Nome = "João",Senha = 1234 },
                new Funcionario { Nome = "Jose",Senha = 5678 },
                new Funcionario { Nome = "Maria",Senha = 9101112},
                new Funcionario { Nome = "Joaquina",Senha = 13141516 },
                new Funcionario { Nome = "Benedita ",Senha = 17181920 },
                new Funcionario { Nome = "Madalena",Senha = 21222324 },
            };
            foreach (Funcionario p in funcionarios)
            {
                context.Funcionarios.Add(p);
            }
            context.SaveChanges();
        }



























    }
}

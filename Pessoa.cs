using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca_Web_System.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int DataNascimento { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public string Endereço { get; set; }

    }
}

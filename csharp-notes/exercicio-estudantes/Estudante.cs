using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_estudantes
{
    internal class Estudante
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Estudante(string name, string mail)
        {
            Name = name;
            Email = mail;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}

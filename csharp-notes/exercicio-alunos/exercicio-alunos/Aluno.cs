using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_alunos
{
    internal class Aluno
    {
        public string Nome;
        public double n1, n2, n3;
        public bool aprovado;

        public double NotaFinal()
        {
            return n1 + n2 + n3;
        }

        public bool Aprovacao()
        {
            if (NotaFinal() > 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovacao())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}

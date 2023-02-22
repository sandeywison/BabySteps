using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes
{
    internal class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }

        public string StatusDoAluno()
        {
            if (NotaFinal() < 60)
            {
                return "REPROVADO" + $"Faltam {60 - NotaFinal()} para ser aprovado.";
            }
            else
            {
                return "APROVADO";
            }
        }
    }
}

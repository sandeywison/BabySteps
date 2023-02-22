using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes
{
    internal class ConversorDeMoeda
    {
        static public double Conversao(double montante, double cotacao)
        {
            return montante * cotacao * 1.06;
        }
    }
}

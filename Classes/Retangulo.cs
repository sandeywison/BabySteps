using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes
{
    internal class Retangulo
    {
        public double A;
        public double B;

        public double AreaDoRetangulo()
        {
            return A * B;
        }

        public double PerimetroDoRetangulo()
        {
            return 2 * A + 2 * B;
        }

        public double DiagonalDoRetangulo()
        {
            double d = Math.Sqrt(Math.Pow(A, 2) + B * B);
            return d;
        }
    }


}

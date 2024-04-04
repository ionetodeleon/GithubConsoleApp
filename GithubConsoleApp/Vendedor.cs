using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubConsoleApp
{
    internal class Vendedor
    {
        public double Sueldo { get; set; }
        public double Premio { get; set; }
        public Vendedor(Premio premio, double sueldo)
        {
            Premio = (double)premio;
            Sueldo = sueldo;
        }
        public double ObtenerSueldo()
        {
            return Sueldo + Premio;
        }
    }
}

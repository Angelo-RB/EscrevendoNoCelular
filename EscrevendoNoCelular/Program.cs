using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular
{
    public class Program
    {
        static NumerosParaLetras numerosParaLetras = new NumerosParaLetras();

        static void Main(string[] args)
        {
            numerosParaLetras.SMS();
            Console.ReadKey();
        }
    }
}

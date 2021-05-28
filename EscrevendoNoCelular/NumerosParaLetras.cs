using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular
{
    public class NumerosParaLetras
    {
        public void SMS()
        {
            int number;

            Console.WriteLine("╔════════════════╗");
            Console.WriteLine("║      ABC  DEF  ║");            
            Console.WriteLine("║  1    2    3   ║");
            Console.WriteLine("║════════════════║");
            Console.WriteLine("║ GHI  JKL  MNO  ║");
            Console.WriteLine("║  4    5    6   ║");
            Console.WriteLine("║════════════════║");
            Console.WriteLine("║ PQRS TUV  WXYZ ║");
            Console.WriteLine("║  7    8    9   ║");
            Console.WriteLine("║════════════════║");
            Console.WriteLine("║     Espaço     ║");
            Console.WriteLine("║       0        ║");
            Console.WriteLine("╚════════════════╝");

            Console.WriteLine("Digite S para sair.");

            number = Convert.ToInt32(Console.ReadLine());

            bool showMenu = true;
            while (showMenu)
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("1 Não contém letras!!");
                        return ;
                    case 0:
                        Console.WriteLine("_");
                        return;
                    case 2:
                        Console.WriteLine("A");
                        return;
                    case 22:
                        Console.WriteLine("B");
                        return;
                    case 222:
                        Console.WriteLine("C");
                        return;
                    case 3:
                        Console.WriteLine("D");
                        return;
                    case 33:
                        Console.WriteLine("E");
                        return;
                    case 333:
                        Console.WriteLine("F");
                        return;
                    case 4:
                        Console.WriteLine("G");
                        return;
                    case 44:
                        Console.WriteLine("H");
                        return;
                    case 444:
                        Console.WriteLine("I");
                        return;
                    case 5:
                        Console.WriteLine("J");
                        return;
                    case 55:
                        Console.WriteLine("K");
                        return;
                    case 555:
                        Console.WriteLine("L");
                        return;
                    case 6:
                        Console.WriteLine("M");
                        return;
                    case 66:
                        Console.WriteLine("N");
                        return;
                    case 666:
                        Console.WriteLine("O");
                        return;
                    case 7:
                        Console.WriteLine("P");
                        return;
                    case 77:
                        Console.WriteLine("Q");
                        return;
                    case 777:
                        Console.WriteLine("R");
                        return;
                    case 7777:
                        Console.WriteLine("S");
                        return;
                    case 8:
                        Console.WriteLine("T");
                        return;
                    case 88:
                        Console.WriteLine("U");
                        return;
                    case 888:
                        Console.WriteLine("V");
                        return;
                    case 9:
                        Console.WriteLine("W");
                        return;
                    case 99:
                        Console.WriteLine("X");
                        return;
                    case 999:
                        Console.WriteLine("Y");
                        return;
                    case 9999:
                        Console.WriteLine("Z");
                        return;                    
                }                
            }

            Console.WriteLine(number);
        }
    }
}

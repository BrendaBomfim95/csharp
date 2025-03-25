using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO
  {
    internal class Program
    {
        static void Main(string[] args)
        {
            {//inicio

                int op;
                INICIO:
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.SetCursorPosition(5, 3);
                Console.WriteLine("╔══════════════════════════════╗");
                Console.SetCursorPosition(5, 4);
                Console.WriteLine("║                              ║");
                Console.SetCursorPosition(5, 5);
                Console.WriteLine("╠══════════════════════════════╣");
                Console.SetCursorPosition(5, 6);
                Console.WriteLine("║   Escolha a opção desejada   ║");
                Console.SetCursorPosition(5, 7);
                Console.WriteLine("╠══════════════════════════════╣");
                Console.SetCursorPosition(5, 8);
                Console.WriteLine("║1 - ADICAO                    ║");
                Console.SetCursorPosition(5, 9);
                Console.WriteLine("║2 - SUBTRAÇÃO                 ║");
                Console.SetCursorPosition(5, 10);
                Console.WriteLine("║3 - MULTIPLICAÇÃO             ║");
                Console.SetCursorPosition(5, 11);
                Console.WriteLine("║4 - DIVISÃO                   ║");
                Console.SetCursorPosition(5, 12);
                Console.WriteLine("║                              ║");
                Console.SetCursorPosition(5, 13);
                Console.WriteLine("╠══════════════════════════════╣");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(15, 4);
                Console.WriteLine("CALCULADORA");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(5, 14);
                Console.WriteLine("║                              ║");
                Console.SetCursorPosition(5, 15);
                Console.WriteLine("╚══════════════════════════════╝");
                Console.SetCursorPosition(9, 14);
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.WriteLine("ADICAO 1 ");
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Double valorA, valorB, RESULTADO;
                        Console.WriteLine("Digite o primeiro valor");
                        valorA = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo valor");
                        valorB = Convert.ToDouble(Console.ReadLine());
                        RESULTADO = valorA + valorB;
                        Console.Write("O resultado da soma é:" + RESULTADO);

                        break;

                    case 2:
                        Console.WriteLine("SUBTRAÇÃO 2");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Double V1, V2, RESULT;
                        Console.WriteLine("Digite o primeiro valor");
                        V1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo valor");
                        V2 = Convert.ToDouble(Console.ReadLine());
                        RESULT = V1 - V2;
                        Console.Write("O resultado da subtração é:" + RESULT);

                        break;

                    case 3:
                        Console.WriteLine("MULTIPLICAÇÃO 3");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Double VAL1, VAL2, RESUL;
                        Console.WriteLine("Digite o primeiro valor");
                        VAL1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo valor");
                        VAL2 = Convert.ToDouble(Console.ReadLine());
                        RESUL = VAL1 * VAL2;
                        Console.Write("O resultado da multiplicação é:" + RESUL);

                        break;

                    case 4:
                        Console.WriteLine("DIVISÃO 4");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Double VA1, VA2, RES;
                        Console.WriteLine("Digite o primeiro valor");
                        VA1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo valor");
                        VA2 = Convert.ToDouble(Console.ReadLine());
                        RES = VA1 / VA2;
                        Console.Write("O resultado da divisão é:" + RES);

                        break;


                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Opção invalida, digite novamente...");
                        goto INICIO;

                }
                Console.ReadKey();

            }
        }
    }

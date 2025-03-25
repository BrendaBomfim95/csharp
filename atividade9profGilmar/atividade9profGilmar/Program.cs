using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade9profGilmar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            INICIO:

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("╔══════════════════════════════╗");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("║     SELECIONE SEU CARGO      ║");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("╠══════════════════════════════╣");
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("║                              ║");
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("║  1 - GERENTE                 ║");
            Console.SetCursorPosition(5, 8);
            Console.WriteLine("║  2 - ANALISTA                ║");
            Console.SetCursorPosition(5, 9);
            Console.WriteLine("║  3 - TECNICO                 ║");
            Console.SetCursorPosition(5, 10);
            Console.WriteLine("║  4 - OUTROS                  ║");
            Console.SetCursorPosition(5, 11);
            Console.WriteLine("║                              ║");
            Console.SetCursorPosition(5, 12);
            Console.WriteLine("╚══════════════════════════════╝");

            Console.SetCursorPosition(6, 15);
            Console.WriteLine("╔═══════╗");
            Console.SetCursorPosition(6, 16);
            Console.WriteLine("║       ║");
            Console.SetCursorPosition(6, 17);
            Console.WriteLine("╚═══════╝");
            Console.SetCursorPosition(10, 16);
            Console.ForegroundColor = ConsoleColor.DarkRed;


            op = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            double SALARIOINICIAL, SALARIOFINAL, DIFERENCA;



            switch (op)

            {




                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(10, 4);
                    Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                    Console.SetCursorPosition(10, 5);
                    Console.WriteLine("║                               GERENTE                                  ║");
                    Console.SetCursorPosition(10, 6);
                    Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                    Console.SetCursorPosition(10, 7);
                    Console.WriteLine("║                         Digite seu salário                             ║");
                    Console.SetCursorPosition(10, 8);
                    Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                    Console.SetCursorPosition(10, 9);
                    Console.WriteLine("║                                                                        ║");
                    Console.SetCursorPosition(10, 10);
                    Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                    Console.SetCursorPosition(10, 11);
                    Console.WriteLine("║                                                                        ║");
                    Console.SetCursorPosition(38, 9);
                    SALARIOINICIAL = Convert.ToDouble(Console.ReadLine());

                    SALARIOFINAL = SALARIOINICIAL + (SALARIOINICIAL * 0.1);

                    DIFERENCA = SALARIOINICIAL * 0.1;
                    Console.SetCursorPosition(10, 12);
                    Console.WriteLine("║      Com base no seu antigo salário de:" + SALARIOINICIAL + "                             ║");
                    Console.SetCursorPosition(10, 13);
                    Console.WriteLine("║      Sua diferença salárial é de:" + DIFERENCA + "                                        ║");
                    Console.SetCursorPosition(10, 14);
                    Console.WriteLine("║      Seu novo salário é de:" + SALARIOFINAL + "                                           ║");
                    Console.SetCursorPosition(10, 15);
                    Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");


                    break;



                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.SetCursorPosition(10, 4);
                    Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                    Console.SetCursorPosition(10, 5);
                    Console.WriteLine("║                               ANALISTA                                 ║");
                    Console.SetCursorPosition(10, 6);
                    Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                    Console.SetCursorPosition(10, 7);
                    Console.WriteLine("║                         Digite seu salário                             ║");
                    Console.SetCursorPosition(10, 8);
                    Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                    Console.SetCursorPosition(10, 9);
                    Console.WriteLine("║                                                                        ║");
                    Console.SetCursorPosition(10, 10);
                    Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                    Console.SetCursorPosition(10, 11);
                    Console.WriteLine("║                                                                        ║");
                    Console.SetCursorPosition(38, 9);

                    SALARIOINICIAL = Convert.ToDouble(Console.ReadLine());

                    SALARIOFINAL = SALARIOINICIAL + (SALARIOINICIAL * 0.2);

                    DIFERENCA = SALARIOINICIAL * 0.2;

                    Console.SetCursorPosition(10, 12);
                    Console.WriteLine("║      Com base no seu antigo salário de:" + SALARIOINICIAL + "                             ║");
                    Console.SetCursorPosition(10, 13);
                    Console.WriteLine("║      Sua diferença salárial é de:" + DIFERENCA + "                                    ║");
                    Console.SetCursorPosition(10, 14);
                    Console.WriteLine("║      Seu novo salário é de:" + SALARIOFINAL + "                                         ║");
                    Console.SetCursorPosition(10, 15);
                    Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");



                    break;



                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                    Console.SetCursorPosition(10, 4);
                    Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                    Console.SetCursorPosition(10, 5);
                    Console.WriteLine("║                               TECNICO                                  ║");
                    Console.SetCursorPosition(10, 6);
                    Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                    Console.SetCursorPosition(10, 7);
                    Console.WriteLine("║                         Digite seu salário                             ║");
                    Console.SetCursorPosition(10, 8);
                    Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                    Console.SetCursorPosition(10, 9);
                    Console.WriteLine("║                                                                        ║");
                    Console.SetCursorPosition(10, 10);
                    Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                    Console.SetCursorPosition(10, 11);
                    Console.WriteLine("║                                                                        ║");
                    Console.SetCursorPosition(38, 9);

                    SALARIOINICIAL = Convert.ToDouble(Console.ReadLine());

                    SALARIOFINAL = SALARIOINICIAL + (SALARIOINICIAL * 0.3);

                    DIFERENCA = SALARIOINICIAL * 0.3;

                    Console.SetCursorPosition(10, 12);
                    Console.WriteLine("║      Com base no seu antigo salário de:" + SALARIOINICIAL + "                             ║");
                    Console.SetCursorPosition(10, 13);
                    Console.WriteLine("║      Sua diferença salárial é de:" + DIFERENCA + "                                    ║");
                    Console.SetCursorPosition(10, 14);
                    Console.WriteLine("║      Seu novo salário é de:" + SALARIOFINAL + "                                        ║");
                    Console.SetCursorPosition(10, 15);
                    Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");

                    break;



                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(10, 4);
                    Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                    Console.SetCursorPosition(10, 5);
                    Console.WriteLine("║                               OUTROS                                   ║");
                    Console.SetCursorPosition(10, 6);
                    Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                    Console.SetCursorPosition(10, 7);
                    Console.WriteLine("║                         Digite seu salário                             ║");
                    Console.SetCursorPosition(10, 8);
                    Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                    Console.SetCursorPosition(10, 9);
                    Console.WriteLine("║                                                                        ║");
                    Console.SetCursorPosition(10, 10);
                    Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                    Console.SetCursorPosition(10, 11);
                    Console.WriteLine("║                                                                        ║");
                    Console.SetCursorPosition(38, 9);

                    SALARIOINICIAL = Convert.ToDouble(Console.ReadLine());

                    SALARIOFINAL = SALARIOINICIAL + (SALARIOINICIAL * 0.4);

                    DIFERENCA = SALARIOINICIAL * 0.4;

                    Console.SetCursorPosition(10, 12);
                    Console.WriteLine("║      Com base no seu antigo salário de:" + SALARIOINICIAL + "      ║");
                    Console.SetCursorPosition(10, 13);
                    Console.WriteLine("║      Sua diferença salárial é de:" + DIFERENCA + "             ║");
                    Console.SetCursorPosition(10, 14);
                    Console.WriteLine("║      Seu nov salário é de:" + SALARIOFINAL + "                   ║");
                    Console.SetCursorPosition(10, 15);
                    Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");

                    break;



                default:


                    Console.WriteLine("Opção invalida, digite novamente...");



                    goto INICIO;

            }



            Console.ReadKey();

        }
    }
}

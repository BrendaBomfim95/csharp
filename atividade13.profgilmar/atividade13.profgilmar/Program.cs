using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace atividade13.profgilmar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inicio
            
            int[] a = new int[6] { 01, 09, 17, 23, 35, 48 };
            int[] b = new int[6];
            int f, d, i, c = 0;
            i = 0;
            d = 0;
            f = 0;
            do
            {
                Console.WriteLine("entre com " + (c + 1) + "º número da aposta");
                b[c] = Convert.ToInt32(Console.ReadLine());
                c = c + 1;
            } while (c < 6);
            for (i = 0; i < 6; i++)
            {
                for (d = 0; d < 6; d++)
                {
                    if (a[i] == b[d])
                    {
                        f = f + 1;
                    }
                }
            }
            if (f == 6)
            {
                Console.WriteLine("acertou a mega sena");
            }
            else if (f == 6)
            {
                
                Console.WriteLine("acertou a a quina");
            }
            else if (f == 4)
            {
                
                Console.WriteLine("acertou a a quadra");
            }
            else if (f <= 3)
            {
                
                Console.WriteLine("Não foi dessa vez");
            }
            Console.ReadKey();
            
            
        }//fim





    }
    }


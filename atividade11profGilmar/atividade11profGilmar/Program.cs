using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace atividade11profGilmar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inicio
            int[] num = new int[6];
            Console.WriteLine("Entrar com os valores");
            for (int i = 0; i <= 5; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Digitado");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("indice: " + i + ", valor: " + num[i]);
            }
            Console.WriteLine("----------------------");
            Array.Sort(num);
            Console.WriteLine("Organizado");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("indice: " + i + ", valor: " + num[i]);
            }
            Console.WriteLine("----------------------");
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine("indice: " + i + ", valor: " + num[i]);
            }

            Console.ReadKey();

        }//fim

    }
}

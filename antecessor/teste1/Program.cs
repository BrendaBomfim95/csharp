using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {//inicio
                int antecessor, resultado;
                Console.Write("Digite o número desejado para verificar o antecessor ");
                antecessor = Convert.ToInt32(Console.ReadLine());

                resultado = antecessor - 1;
                Console.Write("Este é o antecessor:" + resultado);
                Console.ReadKey();

            }

            }
    }
}

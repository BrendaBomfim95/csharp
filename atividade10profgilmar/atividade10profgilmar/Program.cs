using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace atividade10profgilmar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //inicio
            int num;
            do
            {
                Console.WriteLine("Digite um numero par:");
                num= Convert.ToInt32(Console.ReadLine());


            } while (num % 2!=0);
            //(num % 2!=0); quando o resto da divisão for diferente de 0, vai continuar dentro do laço.

            Console.WriteLine("numero par:"+num);

            Console.ReadKey();
        }
    }
}

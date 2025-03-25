using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade._12.profGilmar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inicio
            //ATIVIDADE12.exer5
            int[] vetor = new int[15];
            for (int i = 0; i < 15; i++)
            {
                Console.Write("Digite o " + (i+1) + "º numero: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());


            }
            Array.Sort(vetor);
            Console.WriteLine("-------------------------------------------------------");
            for (int i = 0; i < 15; i++)
                Console.WriteLine("Esta é a ordem crescente: " + vetor[i]);

            Console.WriteLine("-------------------------------------------------------");


            for (int i = 14; i >= 0; i--)

                Console.WriteLine("Esta é a ordem decrescente: " + vetor[i]);


            Console.ReadKey();


        }     //fim






    }
}

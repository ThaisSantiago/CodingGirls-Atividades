using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO1----------------------------------------------------------------------------------------------------------------------

            int[] numeros = new int[10];
           
            Console.Write("Entre com um número: "); 
            numeros[0] = int.Parse(Console.ReadLine());

            Console.Write("Entre com um número: ");
            numeros[1] = int.Parse(Console.ReadLine());

            Console.Write("Entre com um número: ");
            numeros[2] = int.Parse(Console.ReadLine());

            Console.Write("Entre com um número: ");
            numeros[3] = int.Parse(Console.ReadLine());

            Console.Write("Entre com um número: ");
            numeros[4] = int.Parse(Console.ReadLine());

            Console.Write("Entre com um número: ");
            numeros[5] = int.Parse(Console.ReadLine());

            Console.Write("Entre com um número: ");
            numeros[6] = int.Parse(Console.ReadLine());

            Console.Write("Entre com um número: ");
            numeros[7] = int.Parse(Console.ReadLine());

            Console.Write("Entre com um número: ");
            numeros[8] = int.Parse(Console.ReadLine());

            Console.Write("Entre com um número: ");
            numeros[9] = int.Parse(Console.ReadLine());


            Console.WriteLine("Usuário digitou os números");
            Console.ReadLine();


            int[] multiplicados5 = new int[10];

            
            multiplicados5[0] = numeros[0] * 5;
            multiplicados5[1] = numeros[1] * 5;
            multiplicados5[2] = numeros[2] * 5;
            multiplicados5[3] = numeros[3] * 5;
            multiplicados5[4] = numeros[4] * 5;
            multiplicados5[5] = numeros[5] * 5;
            multiplicados5[6] = numeros[6] * 5;
            multiplicados5[7] = numeros[7] * 5;
            multiplicados5[8] = numeros[8] * 5;
            multiplicados5[9] = numeros[9] * 5;

            Console.Write("Números digitados: ");
            for (int i = 0; i < 10; i++)
            {
           
                if (i == 9)
                {
                    Console.Write(numeros[i]);
                    Console.Read();
                }
                else
                {
                    Console.Write(numeros[i] + ",");
                }
            }
            Console.ReadLine();
            Console.Write("Números multiplicados por 5 : ");
         
            for (int i1 = 0; i1 < 10; i1++)
            {
                
                if (i1 == 9)
                {
                    Console.Write(multiplicados5[i1]);
                    Console.Read();
                }
                else
                {
                    Console.Write(multiplicados5[i1] + ",");
                }
            }


        }
    }
}

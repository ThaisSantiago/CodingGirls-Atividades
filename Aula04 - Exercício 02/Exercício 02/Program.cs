using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO2----------------------------------------------------------------------------------------------------------------------
            int x = 0;              // variavel para tamanho do vetor par
            int y = 0;              // variavel para tamanho do vetor impar
            int p = 0;              // variavel para entrada dos numeros pares
            int im = 0;             // variavel para entrada dos numeros impares
            int[] numeros = new int[10];    // vetor para numeros de entrada
            
            //------------ENTRADAS DE NÚMEROS
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
            // ---------------------------------------------


            Console.WriteLine("Usuário digitou os números");
            Console.ReadLine();

            for (int i = 0; i < 10; i++)                // determinação automática para tamanho dos vetores
            {
              
                    if (numeros[i] % 2 == 0)            // se par...
                    {
                        x++;        // acrescenta em pares
                    }


                    else                                // se não...
                    {
                        y++;        // acrescenta em impares
                    }
                
            }
           
            int[] numerosPares = new int[x];        // DECLARAÇÃO PÓS DETERMINAÇÃO DE TAMANHO ACIMA
            int[] numerosImpares = new int[y];      // Note "x" e "y"

            for (int i3 = 0; i3 < 10; i3++)
            {
                if (numeros[i3] % 2 == 0)
                {
                    numerosPares[p] = numeros[i3];
                    if (p < x)
                    {
                        p++;
                    }
                }
                else
                {
                    numerosImpares[im] = numeros[i3];
                    if (im < y)
                    {
                        im++;
                    }
                }
            }
            //-------------------------Pares---------------------------------------------------------

            Console.Write("Números Pares: ");
            for (int i1 = 0; i1 < x; i1++)
            {

                if (i1 == x - 1)
                {
                    Console.Write(numerosPares[i1]);
                    Console.Read();
                }
                else
                {
                    Console.Write(numerosPares[i1] + ",");
                }
            }

            //-------------------------Impares---------------------------------------------------------
            Console.ReadLine();
            Console.Write("Números Impares : ");

            for (int i2 = 0; i2 < y; i2++)
            {

                if (i2 == y -1 )
                {
                    Console.Write(numerosImpares[i2]);
                    Console.Read();
                }
                else
                {
                    Console.Write(numerosImpares[i2] + ",");
                }
            }
           

        }
    }
}


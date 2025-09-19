using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
    

            {
               
                List<int> numeros = new List<int>() { 12, 45, 7, 33, 21 };

                Console.WriteLine("Lista de números:");
                for (int i = 0; i < numeros.Count; i++)
                {
                    Console.WriteLine($"Posición {i} = {numeros[i]}");
                }

               
                int mayor = numeros[0];
                int posMayor = 0;

            
                int menor = numeros[0];
                int posMenor = 0;

                for (int i = 1; i < numeros.Count; i++)
                {
                    if (numeros[i] > mayor)
                    {
                        mayor = numeros[i];
                        posMayor = i;
                    }
                    if (numeros[i] < menor)
                    {
                        menor = numeros[i];
                        posMenor = i;
                    }
                }

             
                int medio = numeros[2];
                int posMedio = 2;

                Console.WriteLine($"\nNúmero mayor: {mayor}, en la posición {posMayor}");
                Console.WriteLine($"Número del medio: {medio}, en la posición {posMedio}");
                Console.WriteLine($"Número menor: {menor}, en la posición {posMenor}");

            Console.ReadKey();
        }
        
        }

    }


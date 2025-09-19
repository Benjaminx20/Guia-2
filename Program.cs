using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            ArrayList cantidades = new ArrayList();    
            List<string> palabras = new List<string>()
        {
            "PROGRAMAR",
            "FUTBOL",
            "GUITARRA",
            "ROCK"
        };

          
            foreach (string palabra in palabras)
            {
                cantidades.Add(palabra.Length);
            }

            Console.WriteLine("Palabras en la lista:");
            foreach (string palabra in palabras)
            {
                Console.WriteLine("- " + palabra);
            }

            Console.WriteLine("\nCantidad de letras en cada palabra:");
            foreach (int cantidad in cantidades)
            {
                Console.WriteLine("- " + cantidad);
            }

            Console.ReadKey();
        }
    }



}
   

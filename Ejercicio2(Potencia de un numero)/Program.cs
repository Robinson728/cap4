using System;
//•	Hacer un programa que calcule el resultado de un número elevado a cualquier potencia.

namespace Ejercicio2_Potencia_de_un_numero_
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";
            float num = 0, mult = 0;
            int exponente = 0;

            Console.WriteLine("Este programa calcula la potencia de un numero\n");
            Console.Write("Ingrese el numero: ");
            entrada = Console.ReadLine();
            num = Convert.ToSingle(entrada);

            Console.Write("Ingrese el exponente: ");
            entrada = Console.ReadLine();
            exponente = Convert.ToInt32(entrada);

            mult = num * num;
            for(int i=2; i<exponente; i++)
            {
                mult *= num;
            }

            Console.WriteLine("Resultado es: {0}", mult);
        }
    }
}

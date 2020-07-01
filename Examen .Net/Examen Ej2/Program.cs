using System;

namespace Examen_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numIngresado;

            Console.WriteLine("Ingrese la cantidad de tablas:");

            if (Int32.TryParse(Console.ReadLine(), out numIngresado) != true)
            {
                Console.WriteLine("No es un tipo de dato valido.");
            }
            else
            {
                Tablas(numIngresado);
            }
            Console.ReadKey();
        }

        public static void Tablas(int numIngresado)
        {
            for (int i = 0; i < numIngresado; i++)
            {

                int resultado = 0;
                Console.WriteLine("Pulse una tecla:");
                Console.ReadKey();

                for (int j = 0; j < 10; j++)
                {
                    int multiplicador = j + 1;
                    resultado = (i + 1) * multiplicador;
                    Console.WriteLine($"{i + 1}*{multiplicador} = {resultado}");
                }
            }
        }
    }
}

using System;

namespace Examen_Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitoIngresado;

            Console.WriteLine("Ingrese un numero:");

            if (Int32.TryParse(Console.ReadLine(), out digitoIngresado) !=true)
            {
                Console.WriteLine("No es un tipo de dato valido.");
            }
            else
            {
                GenerarRectangulo(digitoIngresado);
            }
            Console.ReadKey();
        }

        public static void GenerarRectangulo(int digitoIngresado)
        {
            for (int i = 0; i < 5; i++)
            {  
                Console.WriteLine();

            for (int j = 0; j < 3; j++)
                
                if (i == 0 || i == 4 || j == 0 || j == 2 )
                {
                Console.Write($"{digitoIngresado}");
                }
                else
                {
                Console.Write(" ");
                }
            }
        }
    }
}


/*
Ingresa 4
444
4 4
4 4
4 4
444 
*/
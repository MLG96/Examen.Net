using System;

namespace Examen_Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
              var auto = new Vehiculo();
            var moto = new Vehiculo();
            var bici = new Vehiculo();
            var camioneta = new Vehiculo();


            var auto1 = auto;
            var auto2 = auto;

            auto1.Tarifa = "10400";

            auto2.Tarifa = "9600";
           
            moto.Tarifa = "2400";

            bici.Tarifa = "240";

            camioneta.Tarifa = "5400";

            var resultAuto1 = Int32.Parse(auto1.Tarifa);
            var resultAuto2 = Int32.Parse(auto2.Tarifa);
            var resultMoto = Int32.Parse(moto.Tarifa);
            var resultBici = Int32.Parse(bici.Tarifa);
            var resultCamionta = Int32.Parse(camioneta.Tarifa);

            var finalResult = resultAuto1 + resultAuto2 + resultMoto + resultBici + resultCamionta;

            Console.WriteLine(finalResult);
        }
    }
}

// :(
using System;
using System.Linq;
using System.Threading;

namespace KevinQuemagPruebaConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {

            //Pisos

            Thread primer1 = new Thread(NumPeople);
            Console.WriteLine("Primer piso");

            Thread segundo2 = new Thread(NumPeople);
            Console.WriteLine("Segundo piso");

            Thread tercer3 = new Thread(NumPeople);
            Console.WriteLine("Tercer piso");

            Thread cuarto4 = new Thread(NumPeople);
            Console.WriteLine("Cuarto piso");

            Thread quinto5 = new Thread(NumPeople);
            Console.WriteLine("Quinto piso");

            Thread sexto6 = new Thread(NumPeople);
            Console.WriteLine("Sexto piso");

            Thread septimo7 = new Thread(NumPeople);
            Console.WriteLine("Septimo piso");

            Thread octavo8 = new Thread(NumPeople);
            Console.WriteLine("Octavo piso");

            Thread noveno9 = new Thread(NumPeople);
            Console.WriteLine("Noveno piso");

            Thread decimo10 = new Thread(NumPeople);
            Console.WriteLine("Decimo piso");

            Thread onceavo11 = new Thread(NumPeople);
            Console.WriteLine("Onceavo piso");

            Thread doceavo12 = new Thread(NumPeople);
            Console.WriteLine("Doceavo piso");

            primer1.Start();
            segundo2.Start();
            tercer3.Start();
            cuarto4.Start();
            quinto5.Start();
            sexto6.Start();
            septimo7.Start();
            octavo8.Start();
            noveno9.Start();
            decimo10.Start();
            onceavo11.Start();
            doceavo12.Start();

            primer1.Join();
            segundo2.Join();
            tercer3.Join();
            cuarto4.Join();
            quinto5.Join();
            sexto6.Join();
            septimo7.Join();
            octavo8.Join();
            noveno9.Join();
            decimo10.Join();
            onceavo11.Join();
            doceavo12.Join();

        }

        //Logica

        public static void NumPeople()
        {
            var Casita = 0;

            for (int i = 0; i <= 11; i++)
            {
            
                var randomCasita = new Random();
                if (Casita <= 7)
                {
                    Casita++;
                }


                var random = new Random();
                var value = random.Next(0, 6);

                Console.WriteLine($"piso {i} - casita {Casita} - pobracion {value}");

            }
        }
    }
}
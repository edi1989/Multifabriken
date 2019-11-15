using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa listor för samtliga klasser
            List<Car> carList = new List<Car>();
            List<Candy> candyList = new List<Candy>();
            List<Pipe> pipeList = new List<Pipe>();
            List<Oatmilk> oatmilkList = new List<Oatmilk>();

            bool run = true;

            string home()
            { //Huvudmeny
                Console.Clear();
                Console.WriteLine("Välkommen till Multifabriken!");
                Console.WriteLine("[1] Beställ en bil.");
                Console.WriteLine("[2] Beställ godis.");
                Console.WriteLine("[3] Beställ rör.");
                Console.WriteLine("[4] Beställ havremjölk");
                Console.WriteLine("[5] Visa lista på alla dina beställningar");
                Console.WriteLine("[6] Avsluta");
                Console.Write("Välj: ");
                return Console.ReadLine();

            }
            while (run)
                switch (home())
                {

                    case "1": //Beställ bil
                        Console.WriteLine("Beställ en bil:");
                        Console.Write("Välj bilmärke: ");
                        string brand = Console.ReadLine();
                        Console.Write("Välj färg: ");
                        string color = Console.ReadLine();
                        Console.Write("Välj registreringsnummer: ");
                        string registrationNumber = Console.ReadLine();
                        Car newCar = new Car(brand, color, registrationNumber);
                        carList.Add(newCar);
                        break;

                    case "2": // Beställ godis
                        Console.WriteLine("Beställ godis:");
                        Console.Write("Önska smak: ");
                        string candyTaste = Console.ReadLine();
                        Console.Write("Ange antal godisbitar du önskar beställa: ");
                        string candyAmount = Console.ReadLine();
                        Candy newCandy = new Candy(candyTaste, candyAmount);
                        candyList.Add(newCandy);
                        break;

                    case "3": // Beställ rör
                        Console.WriteLine("Beställ rör:");
                        Console.Write("Ange önskad diameter på röret: ");
                        string pipeDiameter = Console.ReadLine();
                        Console.Write("Ange önskad längd på röret: ");
                        string pipeLength = Console.ReadLine();
                        Pipe newPipe = new Pipe(pipeDiameter, pipeLength);
                        pipeList.Add(newPipe);
                        break;

                    case "4": // Beställ havremjölk
                        Console.WriteLine("Beställ havremjölk:");
                        Console.Write("Ange önskad fetthalt: ");
                        string oatMilkFat = Console.ReadLine();
                        Console.Write("Ange önskad litermängd: ");
                        string oatMilkAmount = Console.ReadLine();
                        Oatmilk newOatmilk = new Oatmilk(oatMilkFat, oatMilkAmount);
                        oatmilkList.Add(newOatmilk);
                        break;

                    case "5": // Visa lista för alla beställningar
                        Console.WriteLine("Lista beställningar");
                        Console.WriteLine("-----------------------------");
                        
                        //Loop för alla beställda bilar
                        foreach (Car car in carList) {
                            Console.WriteLine("Bilar som du beställt:");
                            Console.WriteLine($"Registreringsnummer: {car.Brand}, Märke {car.Color}, Färg: {car.RegistrationNumber}");
                            Console.WriteLine();
                        }
                         
                         //Loop för allt beställt godis
                         foreach (Candy candy in candyList) {
                             Console.WriteLine("Godis som du beställt:");
                             Console.WriteLine($"Smak {candy.Taste}, Antal {candy.Amount}");
                             Console.WriteLine();
                         }

                        //Loop för alla beställda rör
                         foreach (Pipe pipe in pipeList) {
                             Console.WriteLine("Rör som du beställt:");
                             Console.WriteLine($"Diameter {pipe.Diameter}, Längd {pipe.Length}");
                             Console.WriteLine();
                         }

                        //Loop för all beställd havremjölk
                         foreach (Oatmilk oatmilk in oatmilkList) {
                             Console.WriteLine("Havremjölk som du beställt:");
                             Console.WriteLine($"Fetthalt {oatmilk.Fatamount}, Litermängd {oatmilk.Literamount}");
                             Console.WriteLine();
                         }
                         {
                         }
                        Console.ReadLine();
                        break;

                    //Avsluta programmet
                    case "6":
                        run = false;
                        Console.Clear();
                        Console.WriteLine("Programmet avslutas nu.");
                        break;
                }
        }
    }
}


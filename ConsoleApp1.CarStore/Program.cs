using System;
using System.Text;

namespace ConsoleApp1.CarStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            CarStore car1 = new CarStore();

            car1.brand = "Bentley";
            car1.model = "Flying Spur";
            car1.city = "Baki";
            car1.graduitionYear = 2021;
            car1.banType = "Sedan";
            car1.color = "Black";
            car1.engine = 4.0;
            car1.enginePower = 550;
            car1.fuelType = "Gasoline";
            car1.kmRate = 1770;
            car1.gearbox = "Automatic";
            car1.transmitter = "Full";
            car1.situation = "Used";
            car1.price = 255000;

           

            CarStore car2 = new CarStore();


            car2.brand = "Audi";
            car2.model = "e-tron Sportback";
            car2.city = "Baki";
            car2.graduitionYear = 2021;
            car2.banType = "Sedan";
            car2.color = "Black";
            car2.engine = 4.0;
            car2.enginePower = 308;
            car2.fuelType = "Elektro";
            car2.kmRate = 0;
            car2.gearbox = "Automatic";
            car2.transmitter = "Full";
            car2.situation = "New";
            car2.price = 73000;

            CarStore car3 = new CarStore();


            car3.brand = "Lexus";
            car3.model = "ES 300";
            car3.city = "Baki";
            car3.graduitionYear = 2019;
            car3.banType = "Sedan";
            car3.color = "White";
            car3.engine = 2.5;
            car3.enginePower = 215;
            car3.fuelType = "Gasline";
            car3.kmRate = 46000;
            car3.gearbox = "Automatic";
            car3.transmitter = "Full";
            car3.situation = "Used";




            CarStore[] cars = new CarStore[3];
            cars[0] = car1;
            cars[1] = car2;
            cars[2] = car3;


            foreach (CarStore car in cars)
            {
                Console.WriteLine(car.GetInfo());

                Console.WriteLine("------------------");
            }
        }
    }
}

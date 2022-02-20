using System;
using System.Threading;

namespace Enums
{
    internal class Program
    { 
        /*
        static void Main(string[]arg)
        {
            Console.WriteLine("---Trafic Light---");
            Type myType = typeof(Light);
            Console.WriteLine(myType);
            string[] names = Enum.GetNames(myType);
            foreach(var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
            string color;
            l1:
            Console.Write("Reng: ");
             color = Console.ReadLine();
            

            if(!Enum.TryParse(color, out Light lq))
            {
                goto l1;
            }
            
            switch (lq)
            {
                case Light.Red:
                    Console.WriteLine("Qirmizi");
                    break;
                case Light.Yellow:
                    Console.WriteLine("Sari");
                    break;
                case Light.Green:
                    Console.WriteLine("Yashil");
                    break;
                default:
                    break;
            }
            
            

        }
        */














        /*
       static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red; 
                string lightColors = TrafficLight(Light.Qirmizi);
                Console.WriteLine(lightColors);
                Console.ForegroundColor = ConsoleColor.White;

                Thread.Sleep(300);


                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                lightColors = TrafficLight(Light.Sari);
                Console.WriteLine(lightColors);
                Console.ForegroundColor = ConsoleColor.White;

                Thread.Sleep(300);


                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                lightColors = TrafficLight(Light.Yashil);
                Console.WriteLine(lightColors);
                Console.ForegroundColor = ConsoleColor.White;

                Thread.Sleep(300);
                
            }
           
        }
        static string TrafficLight(Light colors)
        {
            switch (colors)
            {
                case Light.Qirmizi:
                    return "Qirmizi";
                case Light.Sari:
                    return "Sari";
                case Light.Yashil:
                    return "Yashil";
                default:
                    throw new Exception("xeta");
            }
        }
        
        */
    }
}

using System;
using System.Linq;
using System.Threading;
using ClassLibrary.Helpers;


namespace WorksAtHome.Drafts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Random r = new Random();
            int eded = r.Next(1, 101);
            int counter = 0;
            Console.Write("1-101 arasi eded daxil edin:");
            int numFromUser = Monitor.ReadInteger("Eded Daxil Edin");
            do
            {
               counter++;
                if (eded < numFromUser)
                {
                    numFromUser = Monitor.ReadInteger("Kicik eded daxil et:");
                }
                else if (eded > numFromUser)
                {
                    numFromUser = Monitor.ReadInteger("Boyuk eded daxil et:");
                }
                else
                {
                    break;
                }

            } while (true);
            Console.WriteLine($"*******************************\nTebrikler...{counter} cehtde tapdiniz!!!");
            
            Random r = new Random();
            int len;
            int[] ccod = new int[0];
            for(int i = 65; i < 91; i++)
            {
                len = ccod.Length;
                Array.Resize(ref ccod, len + 1);
                ccod[len] = i;
            }
            for (int i = 97; i < 123; i++)
            {
                len = ccod.Length;
                Array.Resize(ref ccod, len + 1);
                ccod[len] = i;
            }
            for (int i = 48; i < 58; i++)
            {
                len = ccod.Length;
                Array.Resize(ref ccod, len + 1);
                ccod[len] = i;
            }
            Random m  = new Random();
            len = 8;
            int l;
            string s = " ";
            for(int i = 0; i < len; i++)
            {
                l = r.Next(0, ccod.Length);
                int ed = ccod[l];
                char ch = Convert.ToChar(ed);
                s = s + ch.ToString();

            }
            Console.WriteLine(s);
           
            int[] cc = new int[0];
            string e = " ";
            var p1 = Enumerable.Range(65, 26)
                .Union(Enumerable.Range(97, 26))
                .Union(Enumerable.Range(48, 10))
                .ToArray();
            e = e + p1;
            Console.WriteLine(e);
            
            string q = new string(' ', Console.WindowWidth);
            string s = "demo";

            Console.WriteLine("Salam");
            Console.WriteLine("0123456789");
            Console.ReadKey();
            Console.Clear();
            //q = new string(' ', Console.WindowWidth);
            //Console.CursorTop--;
            Console.WriteLine(s);
            //Console.CursorTop--;
            */
            string b = "HEZI ASLANOV ";
            char first;
            string c = b;
           // do
           // {
           //     Console.Clear();
           //     first = b[0];
           //     b = b.Substring(1) + first;
           //     Console.ForegroundColor = ConsoleColor.Green;
           //     Console.WriteLine(b);
           //     Console.ForegroundColor = ConsoleColor.White;
           //     Thread.Sleep(100);
           // }while(true);

            c = c.Substring(2, 4);
            Console.WriteLine(c);
        }
    }
}

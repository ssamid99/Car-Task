using System;

namespace ConsoleApp.Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1) Verilmish metnde { a}
            // simvolun sayi { b}
            // simvolun sayinda nece defe coxdur ?
            string soz = "1) Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?";
           
            int countA = 0;
            int countB = 0;
            double b;
            for (int i = 0; i < soz.Length; i++)
            {
                if (soz[i] == 'a')
                {
                    countA++;
                }
                else if (soz[i] == 'b')
                {
                    countB++;
                }
              
            }
            b = countA * 1.0 / countB;
            Console.WriteLine(countA);
            Console.WriteLine(countB);
            Console.WriteLine(b);
            
            
            //2) Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi { a}
            //simvoludurmu ?
            string soz = "Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu?";
            
            int countA = 0;
            int countB = 0;

            
            for(int i = 0; i < soz.Length; i ++)
            {
                if(i % 2 != 0)
                {
                   countA++;
                   if(soz[i] == 'a')
                   {
                    countB++;
                   }
                }                                              
            }
            if(countA == countB)
            {
                Console.WriteLine("tek yerde dayanan simvollarin hamisi {a} simvoludur");
            }
            else
            {
                Console.WriteLine("tek yerde dayanan simvollarin hamisi { a} simvolu deyil");
            }
            
            Console.WriteLine($"Tek yerde dayanan simvol sayi: {countA}");
            Console.WriteLine($"a simvolunun sayi: {countB}");
            
           // 3) Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi { b}
           // -ye beraberdir.

            string soz = "Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi { b}-ye beraberdir";
            int countA = 0;
            int countB = 0;
            for (int i = 0; i < soz.Length; i++)
            {
                if (i % 2 != 0)
                {
                    countA++;
                  if (soz[i] == 'b')
                  {
                    countB++;
                  }
                }
            }  
            Console.WriteLine($"Tek yerde dayanan simvol sayi: {countA}");
            Console.WriteLine($"'b' simvolunun sayi: {countB}");
            
            // 4) Verilmish metnde sol terefden ilk rast gelinen { a}
            // simvolunun yeri tek ededdi yoxsa cut ?
            string word = "Verilmish metnde sol terefden ilk rast gelinen { a} simvolunun yeri tek ededdi yoxsa cut ?";
            int s = word.IndexOf('a');
            Console.WriteLine($"'a' simvolunun yeri: {s}");
            if(s % 2 == 0)
            {
                Console.WriteLine("{a} simvolunun yeri cut ededdir.");
            }
            else
            {
                Console.WriteLine("{a} simvolunun yeri tek ededdir.");
            }
            
            //5) Verilmish metnde sol terefden saydiqda { a},{ b},{ c}
            //simollarindan hansi birinci gelir?
            string word = "Verilmish metnde sol terefden saydiqda { a},{ b},{ c} simollarindan hansi birinci gelir?";
            char[] symbols = { 'a', 'b', 'c' };
            int index = word.IndexOfAny(symbols);
            Console.WriteLine($"index nomresi ve simvol: {index}.{word[index]}");
            */
            //6) Verilmish metnde { a}
            //simvolunun sol terefden ve sag terefden indexleri eydidirmi?
            //string word = "Verilmish metnde { a} simvolunun her iki terefden indexleri eynidirmi?";
            //int index = word.IndexOf('a');
            //Console.WriteLine(index);
            //string m = word;
            //int q = 0;
            //
            //for (int i = m.Length - 1; i >= 0; i--)
            //{            
            //    q = m[i];
            //    if (q > 0)
            //    {
            //        int s = m.IndexOf('a');
            //        Console.WriteLine(s);
            //    }
            //    
            //}
            //Console.Write(q);
            
















        }
    }
}

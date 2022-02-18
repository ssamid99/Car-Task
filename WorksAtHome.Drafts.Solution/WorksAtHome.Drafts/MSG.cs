using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorksAtHome.Drafts
{
    public class MSG
    {
        public static string RRstr(string msg)

        {
            Console.Write(msg);
            
         
                Console.ForegroundColor = ConsoleColor.Cyan;
                string astr = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            return astr;

           
        }
    }
}

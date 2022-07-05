using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp14
{
    public delegate void Delegate(string message);

    public class ConsoleReader
    {
        public static void onWord(string str)
        {
            Console.WriteLine("onword");
        }

        public static void onNumber(string str)
        {
            Console.WriteLine("onNumber");
        }

        public static void onJunk(string str)
        {
            Console.WriteLine("onJunk");
        }

        public static void Reads(String str)
        {
            //Program p = new Program();
            Delegate cont1 = new Delegate(onWord);
            Delegate cont2 = new Delegate(onNumber);
            Delegate cont3 = new Delegate(onJunk);
            int num = 0;
            var word = "^[A-Z0-9a-z]+$";
            if (int.TryParse(str, out num))
            {
                cont2(str);

            }
            else if (Regex.IsMatch(str, word))
            {
                cont1(str);
            }
            else
            {
                cont3(str);
            }
            Console.ReadLine();
        }
    }
}

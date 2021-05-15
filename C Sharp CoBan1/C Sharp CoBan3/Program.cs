using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_CoBan3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            for(char c = '0'; c <= '9'; c++)
            {
                s = s.Replace(c + "", "");
            }
            Console.WriteLine(s);
        }
    }
}

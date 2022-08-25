using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Solution1
    {
        
        string final_string = "";
        string result = "";
        public void Solve(string s2)
        {
            string[] s6 = s2.Split(' ');
            for (int i1 = 3; i1 < s6.Length - 1; i1++)
            {
                result = result + SetValue.Roman[s6[i1]];
                final_string = final_string + " " + s6[i1];


            }
            RomanToInteger romanToInteger = new RomanToInteger();
            int total = romanToInteger.findValue(result);
            Console.WriteLine(final_string + " " + total);
            //Console.WriteLine(result3);

        }
    }
}

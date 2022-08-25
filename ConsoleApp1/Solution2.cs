using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Solution2
    {
        
        string final_string = "";
        string result = "";
        public void Solve(string s2)
        {
            string[] s6 = s2.Split(' ');
            for (int i1 = 4; i1 < s6.Length - 2; i1++)
            {
                result = result + SetValue.Roman[s6[i1]];
                final_string = final_string + " " + s6[i1];


            }
            RomanToInteger romanToInteger = new RomanToInteger();
            int result3 = romanToInteger.findValue(result);
           double total = result3 * SetValue.obj_name[s6[s6.Length - 2]];
            final_string = final_string +" "+ s6[s6.Length - 2];
            Console.WriteLine(final_string+ " "+ total+ " "+ "Credits");
        }
    }
}

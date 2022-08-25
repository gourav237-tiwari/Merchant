using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    public class InvalidValue : ApplicationException
    {
        public InvalidValue(string msg) : base(msg)
        {

        }
        public override string Message => "I have no idea what you are talking about";
      
    }
     class SetValue
    {
        public static Dictionary<string, char> Roman;
        public static Dictionary<string, double> obj_name;
        public string result;
        public static string HOW_MUCH_IS = "how much is";
        public static string HOW_MANY_CREDITS_IS = "how many credits is";
        public static string IS = " is ";
        public static string CREDITS = " credits";
        public SetValue()
        {
            Roman = new Dictionary<string, char>();
            obj_name = new Dictionary<string, double>();


        }
        public void solve(List<string> s)
        {
            try
            {
                foreach (string s2 in s)
                {
                    string s3 = s2.ToLower();
                    if (s3.StartsWith(HOW_MUCH_IS))
                    {

                        Solution1 s_2 = new Solution1();
                        s_2.Solve(s2);


                    }
                    else if (s3.StartsWith(HOW_MANY_CREDITS_IS))
                    {
                        Solution2 s_2 = new Solution2();
                        s_2.Solve(s2);
                    }
                    else if (s3.Contains(IS) && (!s3.Contains(CREDITS)))
                    {
                        string[] s4 = s2.Split(' ');
                        Roman[s4[0]] = s4[2][0];
                        
                    }
                    else if (s3.Contains(CREDITS) && (s3.Contains(IS)))
                    {
                        map(s2);
                    }
                    else
                    {
                        throw new InvalidValue("I have no idea what you are talking about");


                    }
                }
            }
            catch(InvalidValue ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
        public void map(string s_1)
        {
            string result = "";
            bool flag = false;
            string inter = "";
            int   final = 0;
            string[] s = s_1.Split(' ');
            foreach (string i in s)
            {

                string i2 = i.ToLower();
                if (i2 != "is" && i2 != "credits")
                {


                    if (SetValue.Roman.ContainsKey(i))
                    {
                        result += SetValue.Roman[i];
                    }
                    else if (flag == false)
                    {

                        RomanToInteger romanToInteger = new RomanToInteger();
                        final = romanToInteger.findValue(result);
                        flag = true;
                        inter = i;


                    }
                    if (flag == true && i != inter)
                    {

                        obj_name[inter] = ((Convert.ToDouble(i)) / final);

                        flag = false;
                    }
                }
            }




        }



    }
}

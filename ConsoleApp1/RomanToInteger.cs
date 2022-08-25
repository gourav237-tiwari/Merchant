using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    public class InvalidVOperation : ApplicationException
    {
        public InvalidVOperation(string msg) : base(msg)
        {

        }
        public override string Message => "It does not conatins any Roman digits";

    }
    class RomanToInteger
    {
        private static Dictionary<char, int> Map;
        // Mapping of the Roman digits to its intergers values
        private int result = 0;
        
        public RomanToInteger()
        {
           
                Map = new Dictionary<char, int>();
                Map['I'] = 1;
                Map['V'] = 5;
                Map['X'] = 10;
                Map['L'] = 50;
                Map['C'] = 100;
                Map['D'] = 500;
                Map['M'] = 1000;
            

        }

        public int findValue(string s)
        {
            try
            {
                for (int i = 0; i < s.Length; i++)
                {
                    
                    if (s[i] == 'I')
                    {
                        if (i < s.Length - 1 && (s[i + 1] == 'V' || s[i + 1] == 'X'))
                        {
                            result -= 1;
                        }
                        else
                        {
                            result += 1;
                        }

                    }
                    else if (s[i] == 'X')
                    {

                        if (i < s.Length - 1 && (s[i + 1] == 'C' || s[i + 1] == 'L'))
                        {
                            result -= 10;
                        }
                        else
                        {
                            result += 10;
                        }

                    }
                    else if (s[i] == 'C')
                    {
                        if (i < s.Length - 1 && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                        {
                            result -= 100;
                        }
                        else
                        {
                            result += 100;
                        }

                    }
                    else if (s[i] == 'V' || s[i] == 'L' || s[i] == 'D')
                    {
                        result = result + Map[s[i]];
                    }
                    else
                    {
                        throw new InvalidVOperation("It does not conatins Roman Digits");
                    }

                }
            }
            catch (InvalidVOperation ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            

                return result;
            }
            





    }
}

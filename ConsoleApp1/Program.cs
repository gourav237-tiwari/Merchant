using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coll = new List<string>();
            string file = @"C:\Users\GoTiwari\OneDrive - Affinion Group\Desktop\Practice_DotNet\ConsoleApp1\input.txt";

            

            // To read the entire file at once
            if (File.Exists(file))
            {
                var lines = File.ReadAllLines(file);

                for (int i = 0; i < lines.Length; i++)
                {
                     var fields = lines[i];

                    coll.Add(fields);
                }
            }
           

            SetValue p = new SetValue();
            p.solve(coll);
           
        }
    }
}
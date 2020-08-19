using System;
using System.Collections.Generic;

namespace Basic
{
    class Program2
    {
        static void Main(string[] args)
        {
            string name = "Sachith";
            int age = 5;

            Console.WriteLine($"this is name:{name}");
            Console.WriteLine($"this is age:{age}");
            

            // if (age > 18)
            // {
            //     Console.WriteLine($"You are eligible to watch this video");
            // }
            // else
            // {
            //     Console.WriteLine($"Hup.....!");
            // }

            //CheckEligiblity(age);

        }

        public static void CheckEligiblity(int a){
            if (a > 18)
            {
                Console.WriteLine($"You are eligible to watch this video");
            }
            else
            {
                Console.WriteLine($"Hup.....!");
            }
        }

    }
}

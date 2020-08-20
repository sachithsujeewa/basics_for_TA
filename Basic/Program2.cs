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
            
            CheckEligiblity();
            CheckEligiblity(3,7);


            Console.WriteLine($"this is name:{name}");
            Console.WriteLine($"this is age:{age}");
            
        }

        static void CheckEligiblity(int a=6){
            if (a > 18)
            {
                Console.WriteLine($"You are eligible to watch this video");
            }
            else
            {
                Console.WriteLine($"Hup.....!{a}");
            }
        }
        static void CheckEligiblity(int a, int limit){
            if (a > limit)
            {
                Console.WriteLine($"You are eligible to watch this video");
            }
            else
            {
                Console.WriteLine($"Hup2...!");
            }
        }

        static void SayHello(){
            System.Console.WriteLine("Hello");
        }

    }
}

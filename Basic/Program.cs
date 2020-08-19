using System;
using System.Collections.Generic;

namespace Basic
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     QA sameera = new QA(){
        //         Id = 1,
        //         Name = "Sameera Palansooriya",
        //         Salary = 1000,
        //         IsAutomation = true
        //     };

        //     Developer Sachith = new Developer(){
        //         Id = 1,
        //         Name = "Sachith Sujeewa",
        //         Salary = 1000,
        //         IsSupport = false,
        //         Technologies = new List<string>(){"C#","Java"}
        //     };
        // }

    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }

    class Developer : Employee
    {
        public IList<string> Technologies { get; set; }
        public bool IsSupport { get; set; }
    }

    class QA : Employee
    {
        public bool IsAutomation { get; set; }
    }
}

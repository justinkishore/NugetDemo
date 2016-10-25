using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldHlpr;

namespace NugetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((new Greetings()).msgInEnglish());
            Console.Read();
        }
    }
}

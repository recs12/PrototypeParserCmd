using System;
using CommandLine;

namespace QuickStart
{
    static class Program
    {
        public class Options
        {
            [Option('t', "teamcenter", Required = false, HelpText = "Set macro on teamcenter mode.")]
            public bool Teamcenter { get; set; }

            [Option("name", Required = false, HelpText = "user name.")]
            public string name { get; set; }
        }

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed<Options>(o =>
                   {
                       if (o.Teamcenter)
                       {
                           Console.WriteLine($"Tc enabled : --name {o.name}");
                           Console.WriteLine("Quick Start Example! App is in TC mode!");
                           Console.WriteLine($"user: {o.name}");
                           Console.ReadLine();
                       }
                       else
                       {
                           Console.WriteLine("Quick Start Example! App is in SE mode!");
                           Console.WriteLine($"Current Arguments: --name {o.name}");
                           Console.WriteLine("Quick Start Example!");
                           Console.ReadLine();
                       }
                   });
        }
    }
}
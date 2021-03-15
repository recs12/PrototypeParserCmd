using System;
using CommandLine;

namespace QuickStart
{
    static class Program
    {
        public class Options
        {
            [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
            public bool Verbose { get; set; }

            [Option("filename", Required = false, HelpText = "Input filename.")]
            public string filename { get; set; }
        }

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed<Options>(o =>
                   {
                       if (o.Verbose)
                       {
                           Console.WriteLine($"Verbose output enabled. Current Arguments: --filename {o.filename}");
                           Console.WriteLine("Quick Start Example! App is in Verbose mode!");
                           Console.WriteLine(o.filename);
                           Console.ReadLine();
                       }
                       else
                       {
                           Console.WriteLine($"Current Arguments: --filename {o.filename}");
                           Console.WriteLine("Quick Start Example!");
                           Console.ReadLine();
                       }
                   });
        }
    }
}
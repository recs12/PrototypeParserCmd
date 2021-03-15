using System;
using CommandLine;

namespace QuickStart
{
    static class Program
    {
        public class Options
        {

            // both modes options

            [Option('m', "mode", Required = true, HelpText = "Set the macro mode SE/TC")]
            public string Mode { get; set; }

            [Option('o', "folder-target", Required = false, HelpText = "Directory where all the cads will be downloaded.")]
            public string FolderTarget { get; set; }


            // SE Mode options
            [Option('f', "folder-source", Required = false, HelpText = "Directory containing all the cads.")]
            public string FolderSource { get; set; }

            [Option('j', "file-source", Required = false, HelpText = "Name of the file")]
            public string FileSource { get; set; }

            [Option('q', "file-target", Required = false, HelpText = "Filename as downloaded in the target directory.")]
            public string FileTarget { get; set; }


            // TC Mode options
            [Option('i', "item-number", Required = false, HelpText = "Filename (without extension type.)")]
            public string ItemNumber { get; set; }

            [Option('v', "revision", Required = false, HelpText = "Revision of the cad.")]
            public string Revision { get; set; }

            [Option('u', "user", Required = false, HelpText = "User.")]
            public string User { get; set; }

            [Option('p', "password", Required = false, HelpText = "Password.")]
            public string Password { get; set; }

            [Option('g', "group", Required = false, HelpText = "Group.")]
            public string Group { get; set; }

            [Option('r', "role", Required = false, HelpText = "Role.")]
            public string Role { get; set; }

            [Option('s', "server", Required = false, HelpText = "Server.")]
            public string Server { get; set; }

        }

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed<Options>(o =>
                   {
                       if (o.Mode == "TC")
                       {
                           Console.WriteLine("App is in TC mode");
                           Console.WriteLine($"Tc enabled : --folder-source {o.FolderSource}");
                           Console.WriteLine($"user: {o.FolderSource}");
                           Console.ReadLine();
                       }
                       else
                       {
                           Console.WriteLine("App is in SE mode");
                           Console.WriteLine($"Current Arguments: --folder-source {o.FolderSource}");
                           Console.WriteLine("Quick Start Example!");
                           Console.ReadLine();
                       }
                   }
              );
        }
    }
}
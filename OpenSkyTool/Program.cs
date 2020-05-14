using System;
using System.Net.Http;
using Renci.SshNet;
using SshNet;

namespace OpenSkyTool
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome
            Console.WriteLine("Bibani OpenSky Tool V0.1.0\nPassword is stored in memory!\n");

            // Login
            Console.WriteLine("Enter OpenSky username:");
            Config.Username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            Config.Password = Console.ReadLine();

            // SSH
            var client = new SshClient(Config.Host, Config.Port, Config.Username, Config.Password);
            client.Connect();

            var stream = client.CreateShellStream("", 0, 0, 0, 0, 4096);
            var commandShowTables = client.CreateCommand("-q show tables;");
            var exec = commandShowTables.BeginExecute();
            commandShowTables.OutputStream.CopyTo(Console.OpenStandardOutput());
            commandShowTables.EndExecute(exec);
            
            client.Disconnect();
        }

        public string ConstructQuery(string table, string column, string filter)
        {
            return "";
        }

        public void ParseResult()
        {

        }

        public void WriteToCSV()
        {
            
        }
    }
}

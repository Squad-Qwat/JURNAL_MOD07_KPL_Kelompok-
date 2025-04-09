using CobaJSON1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CobaJSON2 
{
    public class TeamMembers_103022300082
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string age { get; set; }
        public string nim { get; set; }

        public static TeamMembers_103022300082 ReadJSON(string fileName)
        {
            string json = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<TeamMembers_103022300082>(json);
        }

        public void PrintData()
        {
            TeamMembers_103022300082 data = ReadJSON("jurnal7_2_103022300082.json");
            Console.WriteLine("Name: " + data.firstName);
            Console.WriteLine("NIM: " + data.lastName);
            Console.WriteLine("Email: " + data.age);
            Console.WriteLine("Phone: " + data.nim);
        }
    }
}
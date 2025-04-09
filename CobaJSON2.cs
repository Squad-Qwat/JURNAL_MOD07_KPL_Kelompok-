using CobaJSON1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CobaJSON2 
{
    public class Member 
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string age { get; set; }
        public string nim { get; set; }
    }

    public class TeamMembers_103022300082
    {
        public static Member ReadJSON(string fileName)
        {
            string json = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<Member>(json);
        }

        public void PrintData(Member data)
        {
            Console.WriteLine("Name: " + data.firstName);
            Console.WriteLine("NIM: " + data.lastName);
            Console.WriteLine("Email: " + data.age);
            Console.WriteLine("Phone: " + data.nim);
        }
    }
}
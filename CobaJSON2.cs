using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CobaJSON2 
{
    public class member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string age { get; set; }
        public string nim { get; set; }
    }


    public class TeamMembers_103022300082
    {
        public List<member> members { get; set; }
        
        public static void ReadJSON(string fileName)
        {
            string json = File.ReadAllText(fileName);
            TeamMembers_103022300082 data = JsonConvert.DeserializeObject<TeamMembers_103022300082>(json);
            Console.WriteLine("Nama depan: " + data.members.firstName + "Nama belakang: " + data.members.lastName + 
                "jenis kelamin: " + data.members.gender + "age: " + data.members.age + "NIM: " + data.members.nim);
        }
    }
}
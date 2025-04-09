using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Jurnal07_Kelompok.DataMahasiswa103022300121;

namespace Jurnal07_Kelompok
{
    class TeamMembers103022300121
    {
        public class Mahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
            
        }

        public class Members
        {
            public List<Mahasiswa> members { get; set; }
        }

        public void ReadJSON(string filePath)
        {

            string json = File.ReadAllText(filePath);
            Members data = JsonSerializer.Deserialize<Members>(json);
            Console.WriteLine("Team Member list:");
            foreach (var member in data.members)
            {
                Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Jurnal07_Kelompok.services
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string gender { get; set; }

        public string nim {  get; set; }
    }

    public class Team
    {
        public List<Person> people { get; set; }
    }
    public class TeamMembers_103022300144
    {
        public async Task ReadJson()
        {
            string fileName = "jurnal7_2_103022300144.json";
            using FileStream stream = File.OpenRead(fileName);

            Team? team = await JsonSerializer.DeserializeAsync<Team>(stream);

            Console.WriteLine("Team member: ");
            if (team?.people != null)
            {
                for (int i = 0; i < team?.people.Count; i++)
                {
                    Console.WriteLine("Nama: " + team?.people[i].firstName + " " + team?.people[i].lastName + " umur: " + team?.people[i].age + " jenis kelamin: " + team?.people[i].gender + " nim: " + team?.people[i].nim);
                }
            }
        }
    }
}

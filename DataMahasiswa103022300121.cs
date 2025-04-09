using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Jurnal07_Kelompok
{
    class DataMahasiswa103022300121
    {
        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Mahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public Address address { get; set; }
            public List<Course> courses { get; set; }
        }

        public void ReadJSON(string filePath)
        {

            string json = File.ReadAllText(filePath);
            Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(json);
            Console.WriteLine("Nama: " + data.firstName + " " + data.lastName);
            Console.WriteLine("Gender: " + data.gender);
            Console.WriteLine("Umur: " + data.age);
            Console.WriteLine("===Alamat=== " + data.age);
            Console.WriteLine("Jalan: " + data.address.streetAddress);
            Console.WriteLine("Kota/Kab: " + data.address.city);
            Console.WriteLine("Provinsi: " + data.address.state);
            Console.WriteLine("===Mata Kuliah===");
            int i = 1;
            foreach (var course in data.courses)
            {
                Console.WriteLine("MK " + i + " " + course.code + " - " + course.name);
                i++;
            }

        }

    }
}

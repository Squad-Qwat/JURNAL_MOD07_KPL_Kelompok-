using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Jurnal07_Kelompok.services
{
    public class Address
    {
        public string city { get; set; }

        public string state { get; set; }

        public string streetAddress { get; set; }
    }

    public class Course
    {
        public string name { get; set; }

        public string code { get; set; }
    }
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public Address address { get; set; }
        public List<Course> courses { get; set; }
    }
    public class DataMahasiswa_103022300144
    {
        public async Task ReadJson()
        {
            string fileName = "jurnal7_1_103022300144.json";
            using FileStream stream = File.OpenRead(fileName);

            Student? student = await JsonSerializer.DeserializeAsync<Student>(stream);

            Console.WriteLine("Nama: " + student?.firstName + " " + student?.lastName + " umur: " + student?.age + " jenis kelamin: " + student?.gender + " tinggal di: " + student?.address?.streetAddress + " kota: " + student?.address?.city + " provinsi: " + student?.address?.state);

            Console.WriteLine(" ");

            Console.WriteLine("Mengambil mata kuliah: ");
            if (student?.courses != null)
            {
                for (int i = 0; i < student?.courses.Count; i++)
                {
                    Console.WriteLine("MK: " + student?.courses[i].name + " dengan kode: " + student?.courses[i].code);
                }
            }
        }
    }
}

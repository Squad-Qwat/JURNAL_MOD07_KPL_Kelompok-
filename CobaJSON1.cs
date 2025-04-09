using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CobaJSON1 
{
    public class AddressList 
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class CourseList
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class DataMahasiswa_103022300082
    {
        public string name { get; set; }
        public string nim { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public List<AddressList> address { get; set; }
        public List<CourseList> courses { get; set; }

        public static DataMahasiswa_103022300082 ReadJSON(string fileName) 
        {
            string jsonString = File.ReadAllText(fileName);
            DataMahasiswa_103022300082 data = JsonSerializer.Deserialize<DataMahasiswa_103022300082>(jsonString);
            return data;
        }

        public void PrintData()
        {
            DataMahasiswa_103022300082 data = ReadJSON("jurnal7_1_103022300082.json");
            Console.WriteLine("Name: " + data.name);
            Console.WriteLine("NIM: " + data.nim);
            Console.WriteLine("Email: " + data.email);
            Console.WriteLine("Phone: " + data.phone);

            Console.WriteLine("\nAddress:");
            foreach (var address in data.address)
            {
                Console.WriteLine($"Street Address: {address.streetAddress}, City: {address.city}, State: {address.state}");
            }

            Console.WriteLine("\nCourses:");
            foreach (var course in data.courses)
            {
                Console.WriteLine($"Code: {course.code}, Name: {course.name}");
            }
        }
    }
}
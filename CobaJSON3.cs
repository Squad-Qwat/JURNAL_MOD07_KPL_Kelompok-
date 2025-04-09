using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CobaJSON3
{
    public class glossdef
    {
        public string[] glossSeeAlso { get; set; }
        public string para { get; set; }
    }

    public class glossentry
    {
        public string id { get; set; }
        public string sortas { get; set; }
        public string glossterm { get; set; }
        public glossdef glossDef { get; set; }
        public string Acronym { get; set; }
        public string glossAbbrev { get; set; }
        public string glossSee { get; set; }
    }

    public class glosslist
    {
        public string title { get; set; }
        public glossentry glossEntry { get; set; }
    }

    public class glossdiv
    {
        public string title { get; set; }
        public glosslist glossList { get; set; }
    }

    public class glossary
    {
        public string title { get; set; }
        public glossdiv glossDiv { get; set; }
    }

    public class GlossaryItem_103022300082
    {
        public static glossary ReadJSON(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<glossary>(jsonString);
        }

        public void PrintData(glossary data)
        {
            Console.WriteLine("ID: " + data.glossDiv.glossList.glossEntry.id);
            Console.WriteLine("Sort as: " + data.glossDiv.glossList.glossEntry.sortas);
            Console.WriteLine("Glossary Term: " + data.glossDiv.glossList.glossEntry.glossterm);
            Console.WriteLine("Acronym: " + data.glossDiv.glossList.glossEntry.Acronym);
            Console.WriteLine("Abbrev: " + data.glossDiv.glossList.glossEntry.glossAbbrev);
            foreach (var seealso in data.glossDiv.glossList.glossEntry.glossDef.glossSeeAlso)
            {
                Console.WriteLine("Data GlossSeeAlso : " + seealso);
            }
            Console.WriteLine("GlossSee: " + data.glossDiv.glossList.glossEntry.glossSee);
        }
    }
}
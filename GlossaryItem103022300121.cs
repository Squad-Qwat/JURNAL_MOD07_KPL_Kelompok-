using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Jurnal07_Kelompok
{
    class GlossaryItem103022300121
    {
        public class GlossDef
        {
            public string para { get; set; }
            public List<string> GlossSeeAlso { get; set; }
        }
        public class GlossEntry
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public GlossDef GlossDef { get; set; }
            public string GlossSee { get; set; }
        }

        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; } 
        }

        public class GlossDiv
        {
            public string title { get; set; }
            public GlossList GlossList { get; set; }
        }

        public class GlossaryChild
        {
            public string title { get; set; }
            public GlossDiv GlossDiv { get; set; }
        }

        public class Glossary
        {
            public GlossaryChild glossary { get; set; }
        }

        public void ReadJSON(string filePath)
        {

            string json = File.ReadAllText(filePath);
            Glossary data = JsonSerializer.Deserialize<Glossary>(json);
            Console.WriteLine("ID: " + data.glossary.GlossDiv.GlossList.GlossEntry.ID);
            Console.WriteLine("Sort as: " + data.glossary.GlossDiv.GlossList.GlossEntry.SortAs);
            Console.WriteLine("Acronym: " + data.glossary.GlossDiv.GlossList.GlossEntry.Acronym);
            Console.WriteLine("Abbrev: " + data.glossary.GlossDiv.GlossList.GlossEntry.Abbrev);
            foreach (var seealso in data.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso) 
            {
                Console.WriteLine("Data GlossSeeAlso : " + seealso);
            }
            Console.WriteLine("GlossSee: " + data.glossary.GlossDiv.GlossList.GlossEntry.GlossSee);
        }
    }
}

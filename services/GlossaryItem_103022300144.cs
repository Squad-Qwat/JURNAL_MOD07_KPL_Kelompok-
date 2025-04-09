using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Jurnal07_Kelompok.services
{

    public class GlossDef
    {
        public string para { get; set; }

        public string[] glossSeeAlso { get; set; }
    }

    public class GlossEntry
    {
        public string id { get; set; }
        public string sortAs { get; set; }

        public string glossTerm { get; set; }

        public string acronym { get; set; }

        public string abbrev { get; set; }

        public GlossDef glossDef { get; set; }

        public string glossSee {  get; set; }
    }

    public class  GlossList
    {
        public GlossEntry glossEntry { get; set; }       
    }

    public class  GlossDiv
    {
        public string title {  get; set; }

        public GlossList glossList {  get; set; }
    }

    public class Glossary
    {
        public string title { get; set; }

        public GlossDiv glossDiv { get; set; }
    }
    public class GlossaryItem_103022300144
    {
        public async Task ReadJson()
        {
            string fileName = "jurnal7_3_103022300144.json";
            using FileStream stream = File.OpenRead(fileName);


            Glossary? glossary = await JsonSerializer.DeserializeAsync<Glossary>(stream);

            Console.WriteLine(glossary?.glossDiv.glossList.glossEntry.id);
            Console.WriteLine(glossary?.glossDiv.glossList.glossEntry.acronym);
        }
    }
}

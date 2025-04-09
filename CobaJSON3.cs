using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CobaJSON3
{
    public class glossdef
    {
        public string[] glossseealso { get; set; }
        public string para { get; set; }
    }

    public class glossentry
    {
        public string id { get; set; }
        public string sortas { get; set; }
        public string glossterm { get; set; }
        public string[] glossdef { get; set; }
        public string Acronym { get; set; }
        public string glossabbrev { get; set; }
        public string glosssee { get; set; }
    }

    public class glosslist
    {
        public string title { get; set; }
        public string[] glossentry { get; set; }
    }

    public class glossdiv
    {
        public string title { get; set; }
        public string[] glosslist { get; set; }
    }

    public class glossary
    {
        public string title { get; set; }
        public string[] glossdiv { get; set; }
    }

    public class GlossaryItem_103022300082
    {
        public List<glossary> glossaries { get; set; }

        public static GlossaryItem_103022300082 ReadJSON(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<GlossaryItem_103022300082>(jsonString);
        }
    }
}
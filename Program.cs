using Jurnal07_Kelompok.services;

public class Program
{
    public static async Task Main(string[] args)
    {
        DataMahasiswa_103022300144 mahasiswa = new DataMahasiswa_103022300144();
        await mahasiswa.ReadJson();

        Console.WriteLine("");

        TeamMembers_103022300144 team = new TeamMembers_103022300144();
        await team.ReadJson();

        Console.WriteLine("");

        GlossaryItem_103022300144 gloss = new GlossaryItem_103022300144();
        await gloss.ReadJson();
    }
}
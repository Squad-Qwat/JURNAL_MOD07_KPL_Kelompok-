using Jurnal07_Kelompok.services;

public class Program
{
    public static async Task Main(string[] args)
    {
        DataMahasiswa_103022300144 mahasiswa = new DataMahasiswa_103022300144();
        await mahasiswa.ReadJson();
    }
}
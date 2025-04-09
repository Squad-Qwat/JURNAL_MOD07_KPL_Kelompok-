// See https://aka.ms/new-console-template for more information
using CobaJSON1;

static void Main(string[] args)
{
    string fileName = "jurnal7_1_103022300082.json";
    DataMahasiswa_103022300082 data = DataMahasiswa_103022300082.ReadJSON(fileName);
    data.PrintData();
}
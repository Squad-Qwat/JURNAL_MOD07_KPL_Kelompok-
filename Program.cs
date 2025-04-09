// See https://aka.ms/new-console-template for more information
using CobaJSON1;
using CobaJSON2;
using CobaJSON3;

static void Main(string[] args)
{
    string fileName = "jurnal7_1_103022300082.json";
    DataMahasiswa_103022300082 data = DataMahasiswa_103022300082.ReadJSON(fileName);
    data.PrintData();

    string fileName2 = "jurnal7_2_103022300082.json";
    TeamMembers_103022300082.ReadJSON(fileName2);

    string fileName3 = "jurnal7_3_103022300082.json";
    TeamMembers_103022300082.ReadJSON(fileName3);
}
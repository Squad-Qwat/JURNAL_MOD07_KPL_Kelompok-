// See https://aka.ms/new-console-template for more information
using CobaJSON1;
using CobaJSON2;
using CobaJSON3;

static void Main(string[] args)
{
    string fileName = "jurnal7_1_103022300082.json";
    DataMahasiswa_103022300082 idItem = new DataMahasiswa_103022300082();
    DataMahasiswa iddata = DataMahasiswa_103022300082.ReadJSON(fileName);
    idItem.PrintData(iddata);

    string fileName2 = "jurnal7_2_103022300082.json";
    TeamMembers_103022300082 teamItem = new TeamMembers_103022300082();
    Member teamdata = TeamMembers_103022300082.ReadJSON(fileName2);
    teamItem.PrintData(teamdata);

    string fileName3 = "jurnal7_3_103022300082.json";
    GlossaryItem_103022300082 glosItem = new GlossaryItem_103022300082();
    glossary glosdata = GlossaryItem_103022300082.ReadJSON(fileName3);
    glosItem.PrintData(glosdata);
}
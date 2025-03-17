using Microsoft.VisualBasic;

namespace ApiSegundoDS_bt.models
{
    public class Aluno
    {

        public int Id { get; set; }

        public string? nome { get; set; }
        public string? rma { get; set; }
        public string? pai { get; set; }
        public string? mae { get; set; }
        public int? matricula { get; set; }
        public DateTime datanascimento { get; set; }
        public int escolaid { get; set; }
        public int professorid { get; set; }

    }
}

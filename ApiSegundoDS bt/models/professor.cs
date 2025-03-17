namespace ApiSegundoDS_bt.models
{
    public class professor
    {
                public int Id { get; set; }
        public string? nome { get; set; }
        public string? rma { get; set; }
        public string? pai { get; set; }
        public string? mae { get; set; }
        string nome "mae";
        public string? componentecurricular { get; set; }
        public escola escola { get; set; }
        public Aluno Aluno { get; set; }
    }
}
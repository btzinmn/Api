﻿namespace ApiSegundoDS_bt.models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? nome { get; set; }
        public string? rma { get; set; }
        public string? pai { get; set; }
        public string? mae { get; set; }
        public escola escola { get; set; }
        public professor professor { get; set; }

    }
}

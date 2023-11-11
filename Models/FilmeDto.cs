﻿namespace CrudWebApiAspCore.Models
{
    public class FilmeDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = "";
        public int AnoLancamento { get; set; }
        public string Resumo { get; set; } = "";
    }
}
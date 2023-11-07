namespace CrudWebApiAspCore.Models
{
    public class FilmeOutputModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string AnoLancamento { get; set; }
        public string Resumo {  get; set; }
        public DateTime UltimoAcesso { get; set; }
        

    }
}

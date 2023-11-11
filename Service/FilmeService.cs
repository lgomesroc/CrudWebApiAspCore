using CrudWebApiAspCore.Models;

namespace CrudWebApiAspCore.Service
{
    public class FilmeService : IFilmeService
    {
        public void AddFilme(Filme item)
        {
            FilmeDb.Filmes.Add(item);
        }

        public void DeleteFilme(int id)
        {
            var model = FilmeDb.Filmes.Where(m => m.Id == id).FirstOrDefault();
            FilmeDb.Filmes.Remove(model);
        }

        public bool FilmeExists(int id)
        {
            return FilmeDb.Filmes.Any(m => m.Id == id);
        }

        public Filme GetFilme(int id)
        {
            return FilmeDb.Filmes.Where(m => m.Id == id).FirstOrDefault();
        }

        public List<Filme> GetFilmes()
        {
            return FilmeDb.Filmes.ToList();
        }

        public void UpdateFilme(Filme item)
        {
            var model = FilmeDb.Filmes.Where(m => m.Id == item.Id).FirstOrDefault();

            model.Titulo = item.Titulo;
            model.AnoLancamento = item.AnoLancamento;
            model.Resumo = item.Resumo;
        }
    }
}

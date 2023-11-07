using CrudWebApiAspCore.Models;
using System.Collections.Generic;

namespace CrudWebApiAspCore.Service
{
    public interface IFilmeService
    {
        List<Filme> GetFilmes();
        Filme GetFilme(int id);
        void AddFilme(Filme item);
        void UpdateFilme(Filme item);
        void DeleteFilme(int id);
        bool FilmeExists(int id);
    }
}

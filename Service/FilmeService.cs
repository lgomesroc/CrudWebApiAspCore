using CrudWebApiAspCore.Models;
using System.Collections.Generic;
using System.Linq;

namespace CrudWebApiAspCore.Service
{
    public class FilmeService : IFilmeService
    {
        private readonly List<Filme> filmes;

        public FilmeService()
        {
            this.filmes = new List<Filme>
            {
                new Filme { Id = 1, Titulo = "Moscou contra 007", AnoLancamento = 1983, Resumo = "um agente a serviço da SPECTRE, evela um plano de roubar o criptógrafo Lektor dos soviéticos e vendê-lo novamente aos mesmos, e simultaneamente se vingar de James pelo assassinato de Dr. No." },
                new Filme { Id = 2, Titulo = "Os diamentes são eternos", AnoLancamento = 1971, Resumo = "Bond é encarregado de investigar um misterioso fluxo de diamantes envolvendo África, Estados Unidos e Holanda. Disfarçado como  um contrabandista profissional de nome Peter Franks, Bond viaja a Amsterdão para contactar Tiffany Case." },
                new Filme { Id = 3, Titulo = "Só se vive duas vezes", AnoLancamento = 1967, Resumo = "O Agente 007 é enviado ao Japão para investigar o sequestro de uma nave espacial americana por forças desconhecidas. Logo ao chegar, Bond é contactado por Aki, assistente de Tiger Tanaka, do Serviço Secreto Japonês." }};
        }

        public void AddFilme(Filme item)
        {
            this.filmes.Add(item);
        }

        public void DeleteFilme(int id)
        {
            var model = this.filmes.Where(m => m.Id == id).FirstOrDefault();
            this.filmes.Remove(model);
        }

        public bool FilmeExists(int id)
        {
            return this.filmes.Any(m => m.Id == id);
        }

        public Filme GetFilme(int id)
        {
            return this.filmes.Where(m => m.Id == id).FirstOrDefault();
        }

        public List<Filme> GetFilmes()
        {
            return this.filmes.ToList();
        }

        public void UpdateFilme(Filme item)
        {
            var model = this.filmes.Where(m => m.Id == item.Id).FirstOrDefault();

            model.Titulo = item.Titulo;
            model.AnoLancamento = item.AnoLancamento;
            model.Resumo = item.Resumo;
        }
    }
}

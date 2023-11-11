using CrudWebApiAspCore.Models;

namespace CrudWebApiAspCore
{
    public class FilmeDb
    {
        public static  List<Filme> Filmes = new List<Filme>
        {
            new(){ Id = 1, Titulo = "Moscou contra 007", AnoLancamento = 1983, Resumo = "um agente a serviço da SPECTRE, evela um plano de roubar o criptógrafo Lektor dos soviéticos e vendê-lo novamente aos mesmos, e simultaneamente se vingar de James pelo assassinato de Dr. No." },
            new(){ Id = 2, Titulo = "Os diamentes são eternos", AnoLancamento = 1971, Resumo = "Bond é encarregado de investigar um misterioso fluxo de diamantes envolvendo África, Estados Unidos e Holanda. Disfarçado como  um contrabandista profissional de nome Peter Franks, Bond viaja a Amsterdão para contactar Tiffany Case." },
            new(){ Id = 3, Titulo = "Só se vive duas vezes", AnoLancamento = 1967, Resumo = "O Agente 007 é enviado ao Japão para investigar o sequestro de uma nave espacial americana por forças desconhecidas. Logo ao chegar, Bond é contactado por Aki, assistente de Tiger Tanaka, do Serviço Secreto Japonês." }
        };
    }
}
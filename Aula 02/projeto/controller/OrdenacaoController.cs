using System;
using System.Diagnostics;
using ProjetoOrdenacao.Model;
using ProjetoOrdenacao.View;

namespace ProjetoOrdenacao.Controller
{
    public class OrdenacaoController
    {
        public static void Executar()
        {
            List<int> listaSort = new List<int>();
            List<int> listaBolha = new List<int>();
            List<int> listaSelecao = new List<int>();
            List<int> listaInsercao = new List<int>();
            Stopwatch sw = new Stopwatch();
            int quantidade;

            try
            {
                Console.Write("Quantos números deseja trabalhar? ");
                quantidade = int.Parse(Console.ReadLine());

                //Utilidades.PopularLista(listaBolha, quantidade);
                //Utilidades.PopularLista(listaSelecao, quantidade);
                //Utilidades.PopularLista(listaInsercao, quantidade);
                Utilidades.PopularLista(listaSort, quantidade);

                sw.Start();
                listaSort.Sort();
                sw.Stop();
                ExibicaoView.ExibirTempo(sw, "Ordenando por sort nativo");
                sw.Reset();

                //sw.Start();
                //Ordenacao.Bolha(listaBolha);
                //sw.Stop();
                //ExibicaoView.ExibirTempo(sw, "Ordenando por bolha");
                //sw.Reset();

                //sw.Start();
                //Ordenacao.Selecao(listaSelecao);
                //sw.Stop();
                //ExibicaoView.ExibirTempo(sw, "Ordenando por seleção");
                //sw.Reset();

                //sw.Start();
                //Ordenacao.Insercao(listaInsercao);
                //sw.Stop();
                //ExibicaoView.ExibirTempo(sw, "Exibindo por inserção");
                //sw.Reset();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

using System;
using System.Diagnostics;

namespace ProjetoOrdenacao.View
{
    public class ExibicaoView
    {
        public static void ExibirLista(List<int> lista)
        {
            foreach (int item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public static void ExibirTempo(Stopwatch sw, string frase)
        {
            Console.WriteLine(frase + " (ms): " + sw.ElapsedMilliseconds);
        }
    }
}

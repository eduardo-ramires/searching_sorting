using System;

namespace ProjetoOrdenacao.Model
{
    public class Utilidades
    {
        public static void PopularLista(List<int> lista, int quantidade)
        {
            Random gerador = new Random();
            for (int i = 0; i < quantidade; i++)
            {
                lista.Add(gerador.Next(100000));
            }
        }
    }
}

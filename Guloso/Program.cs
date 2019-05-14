using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guloso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mochila> itens = new List<Mochila>();
            itens.Add(new Mochila(1, 15, 20));
            itens.Add(new Mochila(2, 2, 10));
            itens.Add(new Mochila(3, 1, 15));
            itens.Add(new Mochila(4, 4, 12));
            itens.Add(new Mochila(5, 1, 13));
            int limite = 15;

            Guloso(itens, limite);
        }

        static void Guloso(List<Mochila> itens, int limite)
        {
            double pesoatual = 0;
            double valor = 0;

            itens = itens.OrderByDescending(a => a.valor/a.peso).ToList();
            for(int i = 0; i < itens.Count; i ++)
            {
                if(itens[i].peso <= limite)
                {
                    valor += itens[i].valor;
                    pesoatual += itens[i].peso;
                    limite = limite - itens[i].peso;
                }
            }

            Console.WriteLine("Valor = " +  valor + " peso = " + pesoatual);
            Console.ReadKey();
        }
    }
}

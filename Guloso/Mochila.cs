using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guloso
{
    class Mochila
    {
        public int index { get; set; }
        public int valor { get; set; }
        public int peso { get; set; }

        public Mochila(int index , int peso, int valor )
        {
            this.peso = peso;
            this.valor = valor;
            this.index = index;
        }


    }
}

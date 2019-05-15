using System;
using System.Collections.Generic;
using System.Text;

namespace AED_TP_2
{
    class Arvore
    {
        Arvore nodoDireito;
        Arvore nodoEsquerdo;
        Motorista dado;
        public Arvore()
        {
            NodoDireito = null;
            NodoEsquerdo = null;
            dado = null;
        }

        public Arvore(Motorista dado)
        {
            this.dado = dado;
        }
        
        internal Arvore NodoDireito { get => nodoDireito; set => nodoDireito = value; }
        internal Arvore NodoEsquerdo { get => nodoEsquerdo; set => nodoEsquerdo = value; }
        internal Motorista Dado { get => dado; set => dado = value; }

    }
}

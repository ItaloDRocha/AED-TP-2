using System;
using System.Collections.Generic;
using System.Text;

namespace AED_TP_2
{
    class Arvore
    {
        Arvore pai = null;
        Arvore nodoDireito = null;
        Arvore nodoEsquerdo = null;
        Motorista dado = null;
        public Arvore()
        {
            Pai = null;
            NodoDireito = null;
            NodoEsquerdo = null;
        }

        
        internal Arvore NodoDireito { get => nodoDireito; set => nodoDireito = value; }
        internal Arvore NodoEsquerdo { get => nodoEsquerdo; set => nodoEsquerdo = value; }
        internal Motorista Dado { get => dado; set => dado = value; }
        internal Arvore Pai { get => pai; set => pai = value; }

        public void Inserir(Motorista dado)
        {
            this.dado = dado;
        }

    }
}

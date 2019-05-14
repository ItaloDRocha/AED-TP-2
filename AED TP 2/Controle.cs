using System;
using System.Collections.Generic;
using System.Text;

namespace AED_TP_2
{
    class Controle
    {
        Arvore arvore = new Arvore();
        int cnh;
        int aux = 0;
        public void Construir(Motorista dado)
        {
            if(arvore.Dado == null)
            {
                arvore.Pai.Inserir(dado);
            }
            else
            {
                PercorrerInserir(arvore.Pai, dado);
            }
        }

        public void PercorrerInserir(Arvore nodo, Motorista motorista)
        {
            if (motorista.Cnh == nodo.Dado.Cnh)
            {
                nodo.Dado.adicionarMulta(motorista.NovaMulta);
            }
            else if(motorista.Cnh > nodo.Dado.Cnh)
            {
                if(nodo.NodoDireito.Dado == null)
                {
                    nodo.NodoDireito.Dado = motorista;
                }
                else
                {
                    PercorrerInserir(nodo.NodoDireito, motorista);
                }
            }
            else if (motorista.Cnh < nodo.Dado.Cnh)
            {
                if (nodo.NodoEsquerdo.Dado == null)
                {
                    nodo.NodoEsquerdo.Dado = motorista;
                }
                else
                {
                    PercorrerInserir(nodo.NodoEsquerdo, motorista);
                }
            }
        }

        public Motorista buscar(int cnh)
        {
            if(arvore.Pai.Dado.Cnh == cnh)
            {
                return arvore.Pai.Dado;
            }
            else
            {
               return PercorrerBuscar(cnh, arvore.Pai); //if return == null fala q não achou, caso contrario procurado == return desse metodo.
            }
        }

        public Motorista PercorrerBuscar(int cnh, Arvore nodo)
        {
            if(cnh > nodo.Dado.Cnh)
            {
                if (nodo.NodoDireito.Dado == null)
                {
                    return null;
                }
                else if (nodo.NodoDireito.Dado.Cnh == cnh)
                {
                    return nodo.NodoDireito.Dado;
                }
                else PercorrerBuscar(cnh, nodo.NodoDireito);
            }
            else
            {
                if(cnh < nodo.Dado.Cnh)
                {
                    if (nodo.NodoEsquerdo.Dado == null)
                    {
                        return null;
                    }
                    else if (nodo.NodoEsquerdo.Dado.Cnh == cnh)
                    {
                        return nodo.NodoEsquerdo.Dado;
                    }
                    else PercorrerBuscar(cnh, nodo.NodoEsquerdo);
                }
            }
            return null;
        }
        
    }
}

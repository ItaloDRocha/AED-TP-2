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
                arvore = new Arvore(dado);
            }
            else
            {
                PercorrerInserir(arvore, dado);
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
                if(nodo.NodoDireito == null)
                {
                    nodo.NodoDireito = new Arvore(motorista);
                }
                else
                {
                    PercorrerInserir(nodo.NodoDireito, motorista);
                }
            }
            else if (motorista.Cnh < nodo.Dado.Cnh)
            {
                if (nodo.NodoEsquerdo == null)
                {
                    nodo.NodoEsquerdo = new Arvore(motorista);
                }
                else
                {
                    PercorrerInserir(nodo.NodoEsquerdo, motorista);
                }
            }
        }

        public Motorista buscar(int cnh)
        {
            if(arvore.Dado.Cnh == cnh)
            {
                return arvore.Dado;
            }
            else
            {
                return PercorrerBuscar(cnh, arvore); //if return == null fala q não achou, caso contrario procurado == return desse metodo.
            }
            
        }

        public Motorista PercorrerBuscar(int cnh, Arvore nodo)
        {

            if (cnh > nodo.Dado.Cnh)
            {
                if (nodo.NodoDireito == null)
                {
                    return null;
                }
                else if (nodo.NodoDireito.Dado.Cnh == cnh)
                {
                    return nodo.NodoDireito.Dado;
                }
                else return PercorrerBuscar(cnh, nodo.NodoDireito);
            }
            else
            {
                if(cnh < nodo.Dado.Cnh)
                {
                    if (nodo.NodoEsquerdo == null)
                    {
                        return null;
                    }
                    else if (nodo.NodoEsquerdo.Dado.Cnh == cnh)
                    {
                        return nodo.NodoEsquerdo.Dado;
                    }
                    else return PercorrerBuscar(cnh, nodo.NodoEsquerdo);
                }
            }
            return null;
        }
        
    }
}

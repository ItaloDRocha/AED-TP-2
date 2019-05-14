using System;
using System.Collections.Generic;
using System.Text;

namespace AED_TP_2
{
    class Motorista
    {
        private int cnh;
        List <string> multas;
        private string novaMulta;

        public Motorista(int CNH, string multa)
        {
            this.Cnh = CNH;
            NovaMulta = multa;
            multas.Add(multa);
        }

        public void adicionarMulta(string nova_multa)
        {
            multas.Add(nova_multa);
        }
        public int Cnh { get => cnh; set => cnh = value; }
        public string NovaMulta { get => novaMulta; set => novaMulta = value; }
    }
}

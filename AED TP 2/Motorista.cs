using System;
using System.Collections.Generic;
using System.Text;

namespace AED_TP_2
{
    class Motorista
    {
        private int cnh;
        List <string> multas = new List<string>();
        private string novaMulta;

        public Motorista(int CNH, string multa)
        {
            this.Cnh = CNH;
            NovaMulta = multa;
            if (multas.Count == 0)
            {
                adicionarMulta(NovaMulta);
            }
        }

        public void adicionarMulta(string nova_multa)
        {
            Multas.Add(nova_multa);
        }
        public int Cnh { get => cnh; set => cnh = value; }
        public string NovaMulta { get => novaMulta; set => novaMulta = value; }
        public List<string> Multas { get => multas; set => multas = value; }
    }
}

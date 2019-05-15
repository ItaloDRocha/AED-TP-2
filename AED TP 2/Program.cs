using System;
using System.IO;

namespace AED_TP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Controle controle = new Controle();
            Motorista motorista;
            string data;
            int cnh;
            string [] separador;
            string linha = "-";
            StreamReader leitura = new StreamReader("Multas.txt");
            Console.WriteLine("Construindo arvore multas do arquivo multas.txt...");
            linha = leitura.ReadLine();

            while (linha!= null)
            {
                separador = linha.Split('|');
                cnh = int.Parse(separador[0]);
                data = separador[1];
                motorista = new Motorista(cnh,data);

                linha = leitura.ReadLine();
                controle.Construir(motorista);
            }
            leitura.Close();
            Console.WriteLine("\nArvore inicial construida");
            Console.ReadKey();

           motorista = controle.buscar(0004);
           Console.WriteLine(motorista.Multas.Count);
            Console.ReadKey();
            foreach (string s in motorista.Multas)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();



        }
    }
}

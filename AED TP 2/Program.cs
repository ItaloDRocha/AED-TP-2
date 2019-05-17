using System;
using System.IO;

namespace AED_TP_2
{
    class Program
    {
        static Controle controle = new Controle();
       static Motorista motorista;
        static void Main(string[] args)
        {
            
            string data;
            int cnh;
            string [] separador;
            string linha = "-";
            StreamReader leitura = new StreamReader("Multas.txt");
            Console.WriteLine("Construindo arvore multas do arquivo multas.txt");
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
            Console.WriteLine("\nArvore inicial construida...");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Digite o número correspondente a uma das opções abaixo: ");
            Console.WriteLine("1 .Buscar motorista");
            Console.WriteLine("2 .Inserir multa/motorista");
            Console.WriteLine("3 .Fechar programa\n");
            int opcao = int.Parse(Console.ReadLine());
            int cnhAux;
            string dataAux;
            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o cnh do motorista desejado: ");
                   cnhAux = int.Parse(Console.ReadLine());
                    motorista = controle.buscar(cnhAux);
                    if(motorista == null)
                    {
                        Console.WriteLine("Motorista não encontrado...");
                        Console.ReadKey();
                        Console.WriteLine("\n");
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("O motorista de CNH " + motorista.Cnh + " possui " +motorista.Multas.Count+ " multas no registro.\n");
                        foreach (string s in motorista.Multas)
                        {
                            Console.WriteLine(s);
                        }
                        Console.WriteLine("...");
                        Console.ReadKey();
                        Console.WriteLine("\n");
                        Menu();
                    }
                    break;

                case 2:
                    Console.Write("Digite o CNH do motorista a ser inserido no sistema: ");
                    cnhAux = int.Parse(Console.ReadLine());
                    Console.Write("Digite a data de vencimento da multa a ser inserida no sistema (dd/mm/yyyy): ");
                    dataAux = Console.ReadLine();
                    motorista = new Motorista(cnhAux, dataAux);
                    controle.Construir(motorista);
                    if(controle.buscar(cnhAux) != null)
                    {
                        Console.WriteLine("Motorista e multa inserida no sistema com sucesso...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Motorista e multa não foram inseridos, algo estranho aconteceu...");
                        Console.ReadKey();
                        Console.WriteLine("\n");
                        Menu();
                    }
                    Console.WriteLine("\n");
                    Menu();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("\n");
                    Menu();
                    break;
            }
        }
    }
}

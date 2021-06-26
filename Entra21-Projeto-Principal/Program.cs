using System;

namespace Entra21_Projeto_Principal
{
    class Program
    {

        static void Main(string[] args)
        {
            Iniciando();
        }

        static void Iniciando()
        {
            int escolha_Exercicio = Escolhendo_Exercicio();

            while (escolha_Exercicio != 4)
            {
                Console.Clear();
                Switch_Exercicios(escolha_Exercicio);
                escolha_Exercicio = Escolhendo_Exercicio();

            }
            Console.Clear();
            Console.WriteLine("ADEUS MEU CARO AMIGO!");
        }

        static int Escolhendo_Exercicio()
        {
            int opcao = 0;
            Console.WriteLine("1- Lista de Exercicios 1");
            Console.WriteLine("2- Lista de Exercicios 2");
            Console.WriteLine("3- Lista de Exercicios 3");
            Console.WriteLine("4- Sair");
            opcao = int.Parse(Console.ReadLine());
            return opcao;
        }

        static void Switch_Exercicios(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Exercicio1.Program.Iniciando();
                    break;
                case 2:
                    Exercicio2.Program.Iniciando();
                    break;
                case 3:
                    Exercicio3.Program.Iniciando();
                    break;
            }
        }
    }
}

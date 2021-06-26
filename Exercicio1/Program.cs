using System;

namespace Exercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Iniciando();
        }

        //Operações do codigo de inicialização e escolha
        public static void Iniciando()
        {
            int escolha = 0;

            while (escolha != 11)
            {
                Console.Clear();
                Console.WriteLine("=-= Nível 1: Entrada, Processamento e Saída =-=\n");
                Console.WriteLine("== Escolha a questão que deseja usar ==");
                Console.WriteLine("1 - Questao 1");
                Console.WriteLine("2 - Questao 2");
                Console.WriteLine("3 - Questao 3");
                Console.WriteLine("4 - Questao 4");
                Console.WriteLine("5 - Questao 5");
                Console.WriteLine("6 - Questao 6");
                Console.WriteLine("7 - Questao 7");
                Console.WriteLine("8 - Questao 8");
                Console.WriteLine("9 - Questao 9");
                Console.WriteLine("10 - Questao 10");
                Console.WriteLine("11 - sair\n");
                Console.Write("Digite: ");
                escolha = int.Parse(Console.ReadLine());

                Escolhendo(escolha);

                if (escolha != 11 && escolha < 11)
                {
                    while (Continuar() == 1)
                    {
                        Escolhendo(escolha);
                    }
                }
            }
            Console.Clear();
        }
        static void Escolhendo(int escolha)
        {
            Console.Clear();
            switch (escolha)
            {
                case 1:
                    Questao_1();
                    break;
                case 2:
                    Questao_2();
                    break;
                case 3:
                    Questao_3();
                    break;
                case 4:
                    Questao_4();
                    break;
                case 5:
                    Questao_5();
                    break;
                case 6:
                    Questao_6();
                    break;
                case 7:
                    Questao_7();
                    break;
                case 8:
                    Questao_8();
                    break;
                case 9:
                    Questao_9();
                    break;
                case 10:
                    Questao_10();
                    break;
            }
        }
        public static int Continuar()
        {
            int opcao;
            Console.WriteLine("\nDeseja iniciar novamente? ");
            Console.WriteLine("1- Sim");
            Console.WriteLine("2- Não");
            opcao = int.Parse(Console.ReadLine());
            return opcao;
        }

        //Nível 1: Entrada, Processamento e Saída
        static void Questao_1()
        {
            int Quantidade_Mínima = 0;
            int Quantidade_Máxima = 0;
            int Estoque_Médio = 0;

            // COLETA DE DADOS
            Console.WriteLine("=-= Calculando estoque médio =-=");
            Console.WriteLine("Digite a quantidade minima: ");
            Quantidade_Mínima = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade máxima: ");
            Quantidade_Máxima = int.Parse(Console.ReadLine());

            // CALCULANDO E IMPRIMINDO
            Estoque_Médio = (Quantidade_Mínima + Quantidade_Máxima) / 2;
            Console.WriteLine($"O estoque médio é de {Estoque_Médio}");
        }
        static void Questao_2()
        {
            double Cotação_Dolar = 0;
            double Valor_Dolar = 0;
            double Valor_Real_Total = 0;

            // COLETA DE DADOS
            Console.WriteLine("=-= Conversor: Dolar -> Real =-=");
            Console.WriteLine("Digite o valor da Cotação do dolar: ");
            Cotação_Dolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor à ser convertido: ");
            Valor_Dolar = double.Parse(Console.ReadLine());

            // CALCULANDO E IMPRIMINDO
            Valor_Real_Total = Cotação_Dolar * Valor_Dolar;
            Console.WriteLine($"\nA Conversão para real sera de {Valor_Real_Total.ToString("N2")}");
        }
        static void Questao_3()
        {
            int codigo_Vendedor = 0;
            int codigo_Peça = 0;
            int Quantidade_Vendidas = 0;
            double preço_Unitario = 0;
            double comiçao_Vendedor = 0;

            // COLETA DE DADOS 
            Console.WriteLine("=-= Pagamento de comissão =-=\n");
            Console.WriteLine("- Dados da venda \n");
            Console.Write("Código do vendedor: ");
            codigo_Vendedor = int.Parse(Console.ReadLine());
            Console.Write("Código da peça: ");
            codigo_Peça = int.Parse(Console.ReadLine());
            Console.Write("Preço unitário da peça: ");
            preço_Unitario = double.Parse(Console.ReadLine());
            Console.Write("Quantidade vendida: ");
            Quantidade_Vendidas = int.Parse(Console.ReadLine());

            //FAZENDO O CALCULO DA COMIÇÃO E INPRIMINDO 
            comiçao_Vendedor = (Quantidade_Vendidas * preço_Unitario) * 0.05;
            Console.Clear();
            Console.WriteLine("=-= Pagamento de comissão =-=\n");
            Console.WriteLine($"Vendedor: {codigo_Vendedor}");
            Console.WriteLine($"Vendeu a peça: {codigo_Peça}");
            Console.WriteLine("Venda total de: " + (Quantidade_Vendidas * preço_Unitario) + " reais.");
            Console.WriteLine($"Sua comição será de: {comiçao_Vendedor} reais.");
        }
        static void Questao_4()
        {
            int valor_A = 0;
            int valor_B = 0;
            int valor_C = 0;
            int valor_D = 0;

            // RECOLHENDO DADOS
            Console.WriteLine("=-= Calculando Valores A, B, C, D. =-=\n");
            Console.Write("Digite o valor do A = ");
            valor_A = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B = ");
            valor_B = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C = ");
            valor_C = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de D = ");
            valor_D = int.Parse(Console.ReadLine());

            //CALCULANDO E IMPRIMINDO

            Console.WriteLine("\n-> Somando valores\n");
            Console.WriteLine("A + B = " + (valor_A + valor_B));
            Console.WriteLine("A + C = " + (valor_A + valor_C));
            Console.WriteLine("A + D = " + (valor_A + valor_D));
            Console.WriteLine("B + C = " + (valor_B + valor_C));
            Console.WriteLine("B + D = " + (valor_B + valor_D));
            Console.WriteLine("C + D = " + (valor_C + valor_D));

            Console.WriteLine("\n-> Multiplicando valores\n");
            Console.WriteLine("A * B = " + (valor_A * valor_B));
            Console.WriteLine("A * C = " + (valor_A * valor_C));
            Console.WriteLine("A * D = " + (valor_A * valor_D));
            Console.WriteLine("B * C = " + (valor_B * valor_C));
            Console.WriteLine("B * D = " + (valor_B * valor_D));
            Console.WriteLine("C * D = " + (valor_C * valor_D));
        }
        static void Questao_5()
        {
            double tempo = 0;
            double distancia = 0;
            double velocidade = 0;
            double Litros_gastos = 0;

            //COLETANDO DADOS   
            Console.WriteLine("=-= Calculo de gastos =-=\n");
            Console.Write("Digite as horas gastas: ");
            tempo = double.Parse(Console.ReadLine());
            Console.Write("Digite a velocidade média: ");
            velocidade = double.Parse(Console.ReadLine());

            //CALCULANDO DADOS E IMPRIMINDO
            Console.Clear();
            distancia = tempo * velocidade;
            Litros_gastos = distancia / 12;
            Console.WriteLine($"Velocidade média: {velocidade}");
            Console.WriteLine($"Tempo gasto: {tempo}");
            Console.WriteLine($"A distancia: {distancia}");
            Console.WriteLine($"Litros gastos: {Litros_gastos.ToString("N2")}");

        }
        static void Questao_6()
        {
            double celsius = 0;
            double fahrenheit = 0;

            //COLETANDO DADOS
            Console.WriteLine("=-= Conversão de temperatura =-=\n");
            Console.Write("Digite a temperatura em Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            //CALCULANDO E IMPRIMINDO
            fahrenheit = (9 * celsius + 160) / 5;
            Console.WriteLine($"{celsius} °C em fahrenheit é: {fahrenheit}");
        }
        static void Questao_7()
        {
            double celsius = 0;
            double fahrenheit = 0;

            //COLETANDO DADOS
            Console.WriteLine("=-= Conversão de temperatura =-=\n");
            Console.Write("Digite a temperatura em fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            //CALCULANDO E IMPRIMINDO
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit} fahrenheit em celsius é: {celsius}");
        }
        static void Questao_8()
        {
            double raio = 0;
            double altura = 0;
            double volume = 0;

            //RECOLHENDO DADOS
            Console.WriteLine("=-= Calculando volume de uma lata de óleo =-=\n");
            Console.Write("Digite a raio da lata: ");
            raio = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura da lata: ");
            altura = double.Parse(Console.ReadLine());

            //CALCULANDO E IMPRIMINDO
            volume = 3.14159 * raio * raio * altura;
            Console.WriteLine($"o valor do volume de uma lata de óleo é {volume.ToString("N2")}");
        }
        static void Questao_9()
        {
            int anos = 0;
            int meses = 0;
            int dias = 0;

            //COLETANDO DADOS
            Console.WriteLine("=-= Calculando dias de vida =-=\n");
            Console.WriteLine("--> Digite sua idade");
            Console.Write("Informe quantos anos: ");
            anos = int.Parse(Console.ReadLine());
            Console.Write("informe quantos mêses: ");
            meses = int.Parse(Console.ReadLine());
            Console.Write("Informe quantos dias: ");
            dias = int.Parse(Console.ReadLine());

            //CALCULADO E IMPRIMINDO
            Console.WriteLine($"Você tem {dias + ((anos * 365) + meses * 30)} dias de vida");
        }
        static void Questao_10()
        {
            int valor_A = 0;
            int valor_B = 0;

            //RECOLHENDO DADOS
            Console.WriteLine("=-= Comparando valores =-=\n");
            Console.Write("Informe um valor inteiro: ");
            valor_A = int.Parse(Console.ReadLine());
            Console.Write("Informe outro valor inteiro: ");
            valor_B = int.Parse(Console.ReadLine());

            //CALCULANDO E IMPRIMINDO
            if (valor_A == valor_B)
            {
                Console.WriteLine($"Primeiro valor({valor_A}) é igual ao segundo({valor_B})");
            }
            if (valor_A != valor_B)
            {
                Console.WriteLine($"Primeiro valor({valor_A}) não é igual ao segundo({valor_B})");
            }
            if (valor_A > valor_B)
            {
                Console.WriteLine($"Primeiro valor({valor_A}) é maior que o segundo({valor_B})");
            }
            if (valor_A < valor_B)
            {
                Console.WriteLine($"Primeiro valor({valor_A}) é menor que o segundo({valor_B})");
            }
            if (valor_A >= valor_B)
            {
                Console.WriteLine($"Primeiro valor({valor_A}) é maior ou igual ao segundo({valor_B})");
            }
            if (valor_A <= valor_B)
            {
                Console.WriteLine($"Primeiro valor({valor_A}) é menor ou igual ao segundo({valor_B})");
            }

        }
    }
}

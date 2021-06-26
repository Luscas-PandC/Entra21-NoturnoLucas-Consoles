using System;

namespace Exercicio3
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
            int opcao = 0;

            while (opcao != 4)
            {
                int escolha_Nivel_4 = 0;
                int escolha_Nivel_5 = 0;
                int escolha_Nivel_6 = 0;

                opcao = Escolha_Nivel();

                while (escolha_Nivel_4 != 20 && opcao == 1)
                {
                    escolha_Nivel_4 = Escolha_Questao_N4();

                    Switch_Nivel_4(escolha_Nivel_4);

                    if (escolha_Nivel_4 != 20)
                    {
                        while (Continuar() == 1)
                        {
                            Switch_Nivel_4(escolha_Nivel_4);
                        }
                    }
                }

                while (escolha_Nivel_5 != 16 && opcao == 2)
                {
                    escolha_Nivel_5 = Escolha_Questao_N5();

                    Switch_Nivel_5(escolha_Nivel_5);

                    if (escolha_Nivel_5 != 16)
                    {
                        while (Continuar() == 1)
                        {
                            Switch_Nivel_5(escolha_Nivel_5);
                        }
                    }
                }

                while (escolha_Nivel_6 != 2 && opcao == 3)
                {
                    escolha_Nivel_6 = Escolha_Questao_N6();

                    Switch_Nivel_6(escolha_Nivel_6);

                    if (escolha_Nivel_6 != 2)
                    {
                        while (Continuar() == 1)
                        {
                            Switch_Nivel_6(escolha_Nivel_6);
                        }
                    }
                }
            }
            Console.Clear();
        }
        static int Continuar()
        {
            int opcao;
            Console.WriteLine("\nDeseja iniciar novamente? ");
            Console.WriteLine("1- Sim");
            Console.WriteLine("2- Não");
            opcao = int.Parse(Console.ReadLine());
            return opcao;
        }
        static int Escolha_Nivel()
        {
            int opcao = 0;
            Console.WriteLine("=-= BEM-VINDO =-=\n");
            Console.WriteLine("1- Nível 4: Estruturas de Repetição");
            Console.WriteLine("2- Nível 5: Vetores e Matrizes");
            Console.WriteLine("3- Nível 6: Métodos");
            Console.WriteLine("4- Sair");
            opcao = int.Parse(Console.ReadLine());
            return opcao;

        }
        static int Escolha_Questao_N4()
        {
            int escolha_Nivel_4 = 0;
            Console.Clear();
            Console.WriteLine("=-= Nível 4: Estruturas de Repetição =-=\n");
            Console.WriteLine("== Escolha a questão que deseja usar ==");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{i} - Questao {i + 25}");
            }
            Console.WriteLine("20 - sair\n");
            Console.Write("Digite: ");
            escolha_Nivel_4 = int.Parse(Console.ReadLine());

            return escolha_Nivel_4;
        }
        static void Switch_Nivel_4(int escolha)
        {
            Console.Clear();
            switch (escolha)
            {
                case 1:
                    Questao_4_26();
                    break;
                case 2:
                    Questao_4_27();
                    break;
                case 3:
                    Questao_4_28();
                    break;
                case 4:
                    Questao_4_29();
                    break;
                case 5:
                    Questao_4_30();
                    break;
                case 6:
                    Questao_4_31();
                    break;
                case 7:
                    Questao_4_32();
                    break;
                case 8:
                    Questao_4_33();
                    break;
                case 9:
                    Questao_4_34();
                    break;
                case 10:
                    Questao_4_35();
                    break;
                case 11:
                    Questao_4_36();
                    break;
                case 12:
                    Questao_4_37();
                    break;
                case 13:
                    Questao_4_38();
                    break;
                case 14:
                    Questao_4_39();
                    break;
                case 15:
                    Questao_4_40();
                    break;
                case 16:
                    Questao_4_41();
                    break;
                case 17:
                    Questao_4_42();
                    break;
                case 18:
                    Questao_4_43();
                    break;
                case 19:
                    Questao_4_44();
                    break;

            }
        }
        static int Escolha_Questao_N5()
        {
            int escolha_Nivel_5 = 0;
            Console.Clear();
            Console.WriteLine("=-= Nível 5: Vetores e Matrizes =-=\n");
            Console.WriteLine("== Escolha a questão que deseja usar ==");

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{i} - Questao {i + 44}");
            }
            Console.WriteLine("16 - sair\n");
            Console.Write("Digite: ");
            escolha_Nivel_5 = int.Parse(Console.ReadLine());

            return escolha_Nivel_5;
        }
        static void Switch_Nivel_5(int escolha)
        {
            Console.Clear();
            switch (escolha)
            {
                case 1:
                    Questao_5_45();
                    break;
                case 2:
                    Questao_5_46();
                    break;
                case 3:
                    Questao_5_47();
                    break;
                case 4:
                    Questao_5_48();
                    break;
                case 5:
                    Questao_5_49();
                    break;
                case 6:
                    Questao_5_50();
                    break;
                case 7:
                    Questao_5_51();
                    break;
                case 8:
                    Questao_5_52();
                    break;
                case 9:
                    Questao_5_53();
                    break;
                case 10:
                    Questao_5_54();
                    break;
                case 11:
                    Questao_5_55();
                    break;
                case 12:
                    Questao_5_56();
                    break;
                case 13:
                    Questao_5_57();
                    break;
                case 14:
                    Questao_5_58();
                    break;
                case 15:
                    Questao_5_59();
                    break;
            }
        }
        static int Escolha_Questao_N6()
        {
            int escolha_Nivel_5 = 0;
            Console.Clear();
            Console.WriteLine("=-= Nível 6: Métodos =-=\n");
            Console.WriteLine("== Escolha a questão que deseja usar ==");
            Console.WriteLine("1 - Questao 60");
            Console.WriteLine("2 - sair\n");
            Console.Write("Digite: ");
            escolha_Nivel_5 = int.Parse(Console.ReadLine());

            return escolha_Nivel_5;
        }
        static void Switch_Nivel_6(int escolha)
        {
            Console.Clear();
            switch (escolha)
            {
                case 1:
                    Questao_6_60();
                    break;
            }
        }



        //Nível 4: Estruturas de Repetição
        static void Questao_4_26()
        {
            Console.WriteLine("=-= Contador Decrescente 100 a 1 =-=\n");
            for (int contador = 100; contador > 0; contador--)
            {
                Console.Write(contador + " ");
            }
        }
        static void Questao_4_27()
        {
            int quantidade = 0;


            Console.Write("Digite a quantidade de números que serão calculados: ");
            quantidade = int.Parse(Console.ReadLine());
            int[] valor = new int[quantidade];
            int[] fatoral = new int[quantidade];

            Console.WriteLine($"\n- Digite a seguir os {quantidade} valores a serem fatorados.");

            for (int contador = 0; contador < quantidade; contador++)
            {
                int fator = 1;
                valor[contador] = int.Parse(Console.ReadLine());

                for (int contadorV = 1; contadorV <= valor[contador]; contadorV++)
                {
                    fator *= contadorV;
                    fatoral[contador] = fator;
                }
            }
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"{valor[i]} = {fatoral[i]}");
            }
        }
        static void Questao_4_28()
        {
            int i = 101;
            while (i < 200)
            {
                Console.Write(i + " ");
                i += 2;
            }
        }
        static void Questao_4_29()
        {
            for (int i = 1; i <= 2000; i++)
            {
                Console.Write(i + " ");
            }
        }
        static void Questao_4_30()
        {
            int numero = 0;
            int multiplicado = 0;

            Console.WriteLine("=-= TABUADA =-=\n");
            Console.WriteLine("Informe o número a ser multiplicado: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe até que número ele será multiplicado:");
            multiplicado = int.Parse(Console.ReadLine());

            for (int i = 1; i <= multiplicado; i++)
            {
                Console.WriteLine($"{i} X {numero} = {i * numero}");
            }
        }
        static void Questao_4_31()
        {
            int pares = 0;
            int impares = 0;
            int valor = 0;

            Console.WriteLine("Informe númereos, Digite '-1' para sair\n");
            while (valor != -1)
            {
                valor = int.Parse(Console.ReadLine());
                if (valor % 2 == 0 && valor >= 0)
                {
                    pares += valor;
                    Console.WriteLine("Esse valor é par");
                }
                if (valor % 2 != 0 && valor > 0)
                {
                    impares += valor;
                    Console.WriteLine("Esse valor é impar");
                }
            }
            Console.WriteLine($"A soma dos valores pares deu: {pares}");
            Console.WriteLine($"A soma dos valores impares deu: {impares}");
        }
        static void Questao_4_32()
        {
            int valor = 0;
            int total = 0;
            int testando = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("=-= Calculando a soma dos quadrados dos 20 Primeiros números =-=\n");
                Console.WriteLine("Informe 20 números inteiros, positivos e impares, menor que 10 e maior que 0: ");
                do
                {
                    if (testando == 1)
                    {
                        Console.WriteLine("Número invalido digite novamente: ");
                    }
                    valor = int.Parse(Console.ReadLine());
                    if (valor > 0 && valor < 10)
                    {
                        if (valor % 2 != 0)
                        {
                            total += (valor * valor);
                            testando = 0;
                        }
                        else
                        {
                            testando = 1;
                        }
                    }
                    else
                    {
                        testando = 1;
                    }
                } while (testando == 1);
                Console.Clear();
            }
            Console.WriteLine($"A soma dos quadrados foi: {total}");
        }
        static void Questao_4_33()
        {
            int quantidade_Alunos = 0;
            int matricula_Aluno = 0;
            double nota = 0;
            double media = 0;

            Console.WriteLine("=-= Calculando a media da nota de uma Prova entre os alunos=-=\n");
            Console.WriteLine("Informe a quantidade de alunos: ");
            quantidade_Alunos = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade_Alunos; i++)
            {
                Console.Clear();
                Console.WriteLine("Informe a matrícula do aluno: ");
                matricula_Aluno = int.Parse(Console.ReadLine());
                Console.WriteLine("informe a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());
                media += nota;
            }
            Console.Clear();
            Console.WriteLine("A média dos alunos nessa prova foi de " + (media / quantidade_Alunos));
        }
        static void Questao_4_34()
        {
            decimal valor = 0;
            decimal maior = 0;
            decimal menor = 9999999999999999999;

            Console.WriteLine("=-= Achando o maior e o menor número dentre números positivos =-=\n");
            Console.WriteLine("-Digite um número negativo para finalizar o cod.");
            Console.WriteLine("Inforem números positivos: ");

            while (valor >= 0)
            {
                valor = int.Parse(Console.ReadLine());
                if (valor > maior)
                {
                    maior = valor;
                }
                if (valor < menor && valor >= 0)
                {
                    menor = valor;
                }
            }
            Console.WriteLine($"O maior número informado foi {maior} e o menor foi {menor}.");
        }
        static void Questao_4_35()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine($"{i} Mútiplo de 10!");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Questao_4_36()
        {

        } //
        static void Questao_4_37()
        {

        } //
        static void Questao_4_38()
        {

        } //
        static void Questao_4_39()
        {

        } //
        static void Questao_4_40()
        {

        } //
        static void Questao_4_41()
        {

        } //
        static void Questao_4_42()
        {

        } //
        static void Questao_4_43()
        {

        } //
        static void Questao_4_44()
        {

        } //

        //Nível 5: Vetores e Matrizes
        static void Questao_5_45()
        {
            int posições = 0;

            Console.WriteLine("=-= Imprimindo um vetor na ordem inversa =-=\n");
            Console.Write("Digite o número de posições: ");
            posições = int.Parse(Console.ReadLine());
            int[] vetor = new int[posições];

            Console.WriteLine("");
            for (int i = 0; i < posições; i++)
            {
                vetor[i] = i;
                Console.Write(vetor[i] + " ");
            }

            Console.WriteLine("");
            posições += -1;

            for (int i = posições; i > 0; i--)
            {
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine("");
        }
        static void Questao_5_46()
        {

        } //
        static void Questao_5_47()
        {

        } //
        static void Questao_5_48()
        {

        } //
        static void Questao_5_49()
        {

        } //
        static void Questao_5_50()
        {

        } //
        static void Questao_5_51()
        {

        } //
        static void Questao_5_52()
        {

        } //
        static void Questao_5_53()
        {

        } //
        static void Questao_5_54()
        {

        } //
        static void Questao_5_55()
        {

        } //
        static void Questao_5_56()
        {

        } //
        static void Questao_5_57()
        {

        } //
        static void Questao_5_58()
        {

        } //
        static void Questao_5_59()
        {

        } //

        //Nível 6: Métodos
        static void Questao_6_60()
        {
            int X = 0;
            int Y = 0;

            Console.WriteLine("=-= Plano Carteziano =-=\n");
            Console.Write("Informe o valor de X: ");
            X = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de Y: ");
            Y = int.Parse(Console.ReadLine());

            if (Verifica_Quadrante(X, Y) != 5)
            {
                Console.WriteLine($"\nX e Y (), estão no quadrante {Verifica_Quadrante(X, Y)}\n");
            }
            else
            {
                Console.WriteLine($"\nX e Y (), estão no centro\n");

            }
        }
        static int Verifica_Quadrante(int X, int Y)
        {
            int quadrante = 0;

            if (X >= 0 && Y >= 0)
            {
                quadrante = 1;
            }
            if (X <= 0 && Y >= 0)
            {
                quadrante = 2;
            }
            if (X <= 0 && Y <= 0)
            {
                quadrante = 3;
            }
            if (X >= 0 && Y <= 0)
            {
                quadrante = 4;
            }
            if (X == 0 && Y == 0)
            {
                quadrante = 5;
            }

            return quadrante;
        }
    }
}

using System;

namespace Exercicio2
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

            while (opcao != 3)
            {
                int escolha2 = 0;
                int escolha3 = 0;
                Console.WriteLine("=-= BEM-VINDO =-=\n");
                Console.WriteLine("1- Nível 2: Estruturas Condicionais");
                Console.WriteLine("2- Nível 3: Estrutura de Seleção");
                Console.WriteLine("3- Sair");
                opcao = int.Parse(Console.ReadLine());

                while (escolha2 != 13 && opcao == 1)
                {
                    Console.Clear();
                    Console.WriteLine("=-= Nível 2: Estruturas Condicionais =-=\n");
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
                    Console.WriteLine("11 - Questao 11");
                    Console.WriteLine("12 - Questao 12");
                    Console.WriteLine("13 - sair\n");
                    Console.Write("Digite: ");
                    escolha2 = int.Parse(Console.ReadLine());

                    Switch_Nivel2(escolha2);

                    if (escolha2 != 13)
                    {
                        while (Continuar() == 1)
                        {
                            Switch_Nivel2(escolha2);
                        }
                    }
                }

                while (escolha3 != 4 && opcao == 2)
                {
                    Console.Clear();
                    Console.WriteLine("=-= Nível 3: Estrutura de Seleção =-=\n");
                    Console.WriteLine("== Escolha a questão que deseja usar ==");
                    Console.WriteLine("1 - Questao 1");
                    Console.WriteLine("2 - Questao 2");
                    Console.WriteLine("3 - Questao 3");
                    Console.WriteLine("4 - sair\n");
                    Console.Write("Digite: ");
                    escolha3 = int.Parse(Console.ReadLine());

                    Switch_Nivel3(escolha3);

                    if (escolha3 == 3)
                    {
                        while (Continuar() == 1)
                        {
                            Switch_Nivel3(escolha3);
                        }
                    }
                }
            }
            Console.Clear();
        }
        static void Switch_Nivel2(int escolha)
        {
            Console.Clear();
            switch (escolha)
            {
                case 1:
                    Questao_1_1();
                    break;
                case 2:
                    Questao_1_2();
                    break;
                case 3:
                    Questao_1_3();
                    break;
                case 4:
                    Questao_1_4();
                    break;
                case 5:
                    Questao_1_5();
                    break;
                case 6:
                    Questao_1_6();
                    break;
                case 7:
                    Questao_1_7();
                    break;
                case 8:
                    Questao_1_8();
                    break;
                case 9:
                    Questao_1_9();
                    break;
                case 10:
                    Questao_1_10();
                    break;
                case 11:
                    Questao_1_11();
                    break;
                case 12:
                    Questao_1_12();
                    break;
            }
        }
        static void Switch_Nivel3(int escolha)
        {
            Console.Clear();
            switch (escolha)
            {
                case 1:
                    Questao_3_1();
                    break;
                case 2:
                    Questao_3_2();
                    break;
                case 3:
                    Questao_3_3();
                    break;
            }
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

        //Nível 2: Estruturas Condicionais
        static void Questao_1_1()
        {
            int valor_A = 0;
            int valor_B = 0;
            int aux = 0;

            Console.Write("Informe valor A: ");
            valor_A = int.Parse(Console.ReadLine());
            Console.Write("Informe valor B: ");
            valor_B = int.Parse(Console.ReadLine());

            aux = valor_B;
            valor_B = valor_A;
            valor_A = aux;

            Console.WriteLine($"Valor A: {valor_A} e valor B: {valor_B}");

        }
        static void Questao_1_2()
        {
            int valor = 0;

            Console.WriteLine("Digite um número inteiro: ");
            valor = int.Parse(Console.ReadLine());

            if (valor >= 0)
            {
                Console.WriteLine($"O valor ficou de {valor} ");
            }
            else if (valor < 0)
            {
                Console.WriteLine($"O valor no modulo ficou: {(valor * -1)}");
            }

        }
        static void Questao_1_3()
        {
            int maior = int.Parse(Console.ReadLine());
            int medio = int.Parse(Console.ReadLine());
            int aux;
            if (maior < medio)
            {
                aux = maior;
                maior = medio;
                medio = aux;
            }
            int menor = int.Parse(Console.ReadLine());
            if (menor > maior)
            {
                aux = menor;
                menor = medio;
                medio = maior;
                maior = aux;
            }
            else if (menor > medio)
            {
                aux = menor;
                menor = medio;
                medio = aux;
            }
            Console.WriteLine("A sequencia ficou: ");
            Console.WriteLine(maior);
            Console.WriteLine(medio);
            Console.WriteLine(menor);
        }
        static void Questao_1_4()
        {
            int valor_1 = 0;
            int valor_2 = 0;
            int aux = 0;

            Console.Write("Digite um valor: ");
            valor_1 = int.Parse(Console.ReadLine());
            Console.Write("Digite otro valor: ");
            valor_2 = int.Parse(Console.ReadLine());

            if (valor_1 > valor_2)
            {
                aux = valor_1 - valor_2;
            }
            else if (valor_1 < valor_2)
            {
                aux = valor_2 - valor_1;
            }

            Console.WriteLine($"A diferença do menor numero para o maior é: {aux}");
        }
        static void Questao_1_5()
        {
            string nome = "";
            double nota_1 = 0;
            double nota_2 = 0;
            double nota_3 = 0;
            double nota_4 = 0;
            double media = 0;
            double recuperaçao = 0;

            //COLETAS DE DADOS
            Console.WriteLine("=-= Calculando a média do Aluno =-=\n");
            Console.Write("Informe o nome do Aluno(a): ");
            nome = Console.ReadLine();
            Console.Write("Informe a nota 1: ");
            nota_1 = double.Parse(Console.ReadLine());
            Console.Write("Informe a nota 2: ");
            nota_2 = double.Parse(Console.ReadLine());
            Console.Write("Informe a nota 3: ");
            nota_3 = double.Parse(Console.ReadLine());
            Console.Write("Informe a nota 4: ");
            nota_4 = double.Parse(Console.ReadLine());

            //CALCULANDO E IMPRIMINDO 
            media = (nota_1 + nota_2 + nota_3 + nota_4) / 4;

            if (media >= 7)
            {
                Console.Clear();
                Console.WriteLine($"O Aluno(a) {nome} foi aprovado!");
                Console.WriteLine($"Sua média foi de {media}.");
            }
            else
            {
                Console.Clear();
                Console.Write($"Média desejada não alcançada, Digite a nota de recuperação: ");
                recuperaçao = double.Parse(Console.ReadLine());
                media = media + recuperaçao;

                if (media >= 7)
                {
                    Console.Clear();
                    Console.WriteLine($"O Aluno(a) {nome} foi aprovado na recuperação!");
                    Console.WriteLine($"Sua média foi de {media}.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"O Aluno(a) {nome} foi Reprovado(a)!");
                    Console.WriteLine($"Sua média foi de {media}.");
                }

            }
        }
        static void Questao_1_6()
        {
            double valor_1 = 0;
            double valor_2 = 0;

            Console.WriteLine("=-= Comparando dois valores: =-=\n");
            Console.Write("Informe o primeiro número: ");
            valor_1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            valor_2 = double.Parse(Console.ReadLine());

            if (valor_1 > valor_2)
            {
                Console.WriteLine($"\nO maior número é o primeiro({valor_1}) e o menor é o segundo({valor_2})");
            }
            if (valor_1 < valor_2)
            {
                Console.WriteLine($"\nO maior número é o segundo({valor_2}) e o menor é o primeiro({valor_1})");
            }
            if (valor_1 == valor_2)
            {
                Console.WriteLine($"\nO primeiro({valor_1}) e o segundo({valor_2}) números são iguais. ");
            }
        }
        static void Questao_1_7()
        {
            int numero = 0;
            Console.WriteLine("=-= Validando um número inteiro =-=\n");
            Console.Write("Informe um número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            if (numero < 0 || numero > 9)
            {
                while (numero < 0 || numero > 9)
                {
                    Console.Clear();
                    Console.WriteLine("-Valor inválido.\n");
                    Console.Write("Informe outro valor: ");
                    numero = int.Parse(Console.ReadLine());
                }
            }
            if (numero >= 0 && numero <= 9)
            {
                Console.Clear();
                Console.WriteLine("\n-Valor válido.");
            }
        }
        static void Questao_1_8()
        {
            int codigo = 0;

            Console.WriteLine("=-= Verificando o Código =-=\n");
            Console.Write("Informe um número inteiro: ");
            codigo = int.Parse(Console.ReadLine());

            if (codigo < 0 || codigo > 3)
            {
                while (codigo < 0 || codigo > 3)
                {
                    Console.Clear();
                    Console.WriteLine("-Número inválido.\n");
                    Console.Write("Informe outro número: ");
                    codigo = int.Parse(Console.ReadLine());
                }
            }
            if (codigo == 1 || codigo == 2 || codigo == 3)
            {
                switch (codigo)
                {
                    case 1:
                        Console.WriteLine("\nUm");
                        break;
                    case 2:
                        Console.WriteLine("\nDois");
                        break;
                    case 3:
                        Console.WriteLine("\nTrês");
                        break;
                }
            }
        }
        static void Questao_1_9()
        {
            double valor_A = 0;
            double valor_B = 0;
            double valor_C = 0;

            Console.WriteLine("=-= Informando o tipo de Triângulo =-=\n");
            Console.Write("Informe o valor de um lado(A): ");
            valor_A = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de outro lado(B): ");
            valor_B = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de outro lado(C): ");
            valor_C = double.Parse(Console.ReadLine());

            if (valor_A <= (valor_B + valor_C) && valor_C <= (valor_B + valor_A) && valor_B <= (valor_A + valor_C))
            {
                if (valor_A == valor_B && valor_B == valor_C)
                {
                    Console.WriteLine("\nEsté triângulo é equilátero.");
                }
                else if (valor_A == valor_B || valor_A == valor_C || valor_B == valor_C)
                {
                    Console.WriteLine("\nEsse triângulo é um isóscele");
                }
                else
                {
                    Console.WriteLine("\nEsse triângulo é um escaleno");
                }
            }
            else
            {
                Console.WriteLine("\nEsses valores não formam um triangulo.");
            }
        }
        static void Questao_1_10()
        {
            int valor_A = 0;
            int valor_B = 0;
            int valor_C = 0;
            int maior = 0;
            int menor = 0;

            Console.WriteLine("=-= Lendo três valores inteiros e calculando =-=\n");
            do
            {
                Console.Clear();
                Console.Write("Digite o primeiro valor: ");
                valor_A = int.Parse(Console.ReadLine());
            } while (valor_A <= 0);

            do
            {
                Console.Clear();
                Console.Write("Digite o segundo valor: ");
                valor_B = int.Parse(Console.ReadLine());
            } while (valor_B <= 0);

            do
            {
                Console.Clear();
                Console.Write("Digite o terceiro valor: ");
                valor_C = int.Parse(Console.ReadLine());
            } while (valor_C <= 0);

            maior = valor_A;
            if (valor_B > valor_A && valor_B > valor_C)
            {
                maior = valor_B;
            }
            if (valor_C > valor_B && valor_C > valor_A)
            {
                maior = valor_C;
            }

            menor = valor_A;
            if (valor_B < valor_A && valor_B < valor_C)
            {
                menor = valor_B;
            }
            if (valor_C < valor_B && valor_C < valor_A)
            {
                menor = valor_C;
            }

            Console.WriteLine($"Menor número({menor}) * maior número({maior}) = {(menor * maior)}");
            Console.WriteLine($"Maior número({maior}) / Menor número({menor}) = {(maior / menor)}");
        }
        static void Questao_1_11()
        {
            int numero = 1;

            Console.Clear();
            Console.WriteLine("=-= Descobrindo números Positivos e Negativos =-=\n");
            Console.Write("Digite um valor: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine("Esse número é positivo. ");
            }
            if (numero < 0)
            {
                Console.WriteLine("Esse número é negativo. ");
            }
        }
        static void Questao_1_12()
        {
            int valor = 0;
            int A = 0;
            int B = 0;

            Console.WriteLine("=-= Lendo valor, Se positivo armazene-o em A, se for negativo, em B =-=\n");
            Console.Write("Informe um valor: ");
            valor = int.Parse(Console.ReadLine());

            if (valor >= 0)
            {
                A = valor;
                Console.WriteLine($"O valor positivo {valor} foi armazenado na A");
            }
            if (valor < 0)
            {
                B = valor;
                Console.WriteLine($"O valor negativo {valor} foi armazenado na B");
            }


        }

        //Nível 3: Estrutura de Seleção 

        static void Questao_3_1()
        {
            int opcao = 0;
            double valor_1 = 0;
            double valor_2 = 0;
            double resultado = 0;

            while (opcao != 4)
            {
                Console.Clear();
                Console.WriteLine("=-= Calculadora =-=\n");
                Console.WriteLine("1- Subtração");
                Console.WriteLine("2- Multiplicação");
                Console.WriteLine("3- Divisão");
                Console.WriteLine("4- Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.Write("Informe um valor: ");
                            valor_1 = double.Parse(Console.ReadLine());
                            Console.Write("Informe um valor: ");
                            valor_2 = double.Parse(Console.ReadLine());

                            resultado = valor_1 - valor_2;

                            Console.WriteLine($"{valor_1} - {valor_2} = {resultado.ToString("n2")}");
                        } while (Continuar() == 1);
                        break;

                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.Write("Informe um valor: ");
                            valor_1 = double.Parse(Console.ReadLine());
                            Console.Write("Informe um valor: ");
                            valor_2 = double.Parse(Console.ReadLine());

                            resultado = valor_1 * valor_2;

                            Console.WriteLine($"{valor_1} X {valor_2} = {resultado.ToString("n2")}");
                        } while (Continuar() == 1);
                        break;

                    case 3:
                        do
                        {
                            Console.Clear();
                            Console.Write("Informe um valor: ");
                            valor_1 = double.Parse(Console.ReadLine());
                            Console.Write("Informe um valor: ");
                            valor_2 = double.Parse(Console.ReadLine());

                            resultado = valor_1 / valor_2;

                            Console.WriteLine($"{valor_1} / {valor_2} = {resultado.ToString("n2")}");
                        } while (Continuar() == 1);
                        break;
                }
            }

        }
        static void Questao_3_2()
        {
            double valor_1 = 0;
            double valor_2 = 0;
            int opcao = 0;

            Console.WriteLine("=-= Verificações =-=\n");
            Console.Write("Informe um valor: ");
            valor_1 = double.Parse(Console.ReadLine());
            Console.Write("Informe um valor: ");
            valor_2 = double.Parse(Console.ReadLine());

            while (opcao != 4)
            {
                Console.Clear();
                Console.WriteLine($"=-= valor 1 ({valor_1}) =-= valor 2 ({valor_2}) =-=\n");
                Console.WriteLine("1- Verificar se um dos números lidos é ou não múltiplo do outro");
                Console.WriteLine("2- Verificar se os dois números lidos são pares");
                Console.WriteLine("3- Verificar se a média dos dois números é maior ou igual a 7");
                Console.WriteLine("4- Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        do
                        {
                            int decisao = 0;
                            Console.Clear();
                            Console.WriteLine("=-= Verificando se um dos número lidos é ou não múltiplo do outro =-=");
                            Console.WriteLine($"Escolha: valor 1- ({valor_1}), valor 2- ({valor_2})");
                            decisao = int.Parse(Console.ReadLine());

                            if (decisao == 1)
                            {
                                // valor_1 é multiplo de valor_2?
                                if ((valor_1 % valor_2 == 0) && (valor_1 / valor_2 >= 0))
                                {
                                    Console.WriteLine($"O valor {valor_1} é multiplo de {valor_2}.");
                                }
                                else
                                {
                                    Console.WriteLine($"O valor {valor_1} NÃO é multiplo de {valor_2}.");
                                }

                            }

                            if (decisao == 2)
                            {
                                // valor_2 é multiplo de valor_1?
                                if ((valor_2 % valor_1 == 0) && (valor_2 / valor_1 >= 0))
                                {
                                    Console.WriteLine($"O valor {valor_2} é multiplo de {valor_1}.");
                                }
                                else
                                {
                                    Console.WriteLine($"O valor {valor_2} NÃO é multiplo de {valor_1}.");
                                }

                            }

                        } while (Continuar() == 1);
                        break;

                    case 2:
                        do
                        {
                            Console.Clear();
                            if (valor_1 % 2 == 0)
                            {
                                Console.WriteLine($"O valor {valor_1} é par.");
                            }
                            else
                            {
                                Console.WriteLine($"O valor {valor_1} NÃO é par.");
                            }
                            if (valor_2 % 2 == 0)
                            {
                                Console.WriteLine($"O valor {valor_2} é par.");
                            }
                            else
                            {
                                Console.WriteLine($"O valor {valor_2} NÃO é par.");
                            }
                        } while (Continuar() == 1);
                        break;


                    case 3:
                        do
                        {
                            double media = 0;
                            Console.Clear();
                            media = (valor_1 + valor_2) / 2;
                            if (media >= 7)
                            {
                                Console.WriteLine($"A média({media}) dos valores {valor_1} e {valor_2} foi maior ou igual a 7");
                            }
                            else
                            {
                                Console.WriteLine($"A média({media}) dos valores {valor_1} e {valor_2} foi abaixo de 7");
                            }
                        } while (Continuar() == 1);
                        break;

                }
            }
        }
        static void Questao_3_3()
        {
            int sexo = 0;
            double altura = 0;
            double media = 0;

            Console.WriteLine("=-= Calculando o peso ideial =-=\n");
            Console.WriteLine("-Informe seu sexo");
            Console.WriteLine("1- Mulhere");
            Console.WriteLine("2- Homem");
            sexo = int.Parse(Console.ReadLine());

            Console.Write("\nDigite sua altura: ");
            altura = double.Parse(Console.ReadLine());

            if (sexo == 1)
            {
                media = (62.1 * altura) - 44.7;
                Console.WriteLine($"O seu peso ideial é {media.ToString("n2")}");
            }
            else
            {
                media = (72.7 * altura) - 58;
                Console.WriteLine($"O seu peso ideial é {media.ToString("n2")}");
            }

        }
    }
}

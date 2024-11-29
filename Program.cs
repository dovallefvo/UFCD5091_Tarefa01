using System;
using static System.Console;

namespace Tarefa01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operacao = 0;
            int numero = 0;
            string resposta = "";

            WriteLine("Informe o número da operação desejada:\n 1 - Quadrado do número\n 2 - Metade do número\n 3 - Dobro do número\n\n");

            operacao = LerConsole("Digite a operação desejada: ");
            numero = LerConsole("Digite o número que sofrerá a operação: ");

            switch (operacao)
            {
                case 1:
                    {
                        numero = numero * numero;
                        resposta = "O Quadrado do valor introduzido é: " + numero;
                        break;
                    }
                case 2:
                    {
                        numero /= 2;
                        resposta = "A metade do valor introduzido é: " + numero;
                        break;
                    }
                case 3:
                    {
                        numero *= 2;
                        resposta = "O dobro do valor é: " + numero;
                        break;
                    }
                default:
                    {
                        resposta = "A operação informada está fora dos valores possíveis.";
                        break;
                    }
            }

            WriteLine(resposta);
            WriteLine("****FIM DO PROGRAMA*** presssione qualquer tecla para sair");
        }

        private static int LerConsole(string mensagem)
        {
            int valor_informado = 0;
            while (valor_informado == 0)
            {
                try
                {
                    WriteLine(mensagem);
                    valor_informado = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("O valor informado não é um número." + ex.Message);
                }
            }

            return valor_informado;
        }
    }
}

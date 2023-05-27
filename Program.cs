using System;
using DesafioFundamentos.Models;

namespace DesafioFundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizado para exibir acentuação
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            decimal precoInicial = 0;
            decimal precoPorHora = 0;

            System.Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                                      "Digite o preço inicial:");
            precoInicial = Convert.ToDecimal(Console.ReadLine());

            System.Console.WriteLine("Agora digite o preço por hora:");
            precoPorHora = Convert.ToDecimal(Console.ReadLine());

            //Instancia a classe Estacionamento, já com os valores obtidos anteriormente
            Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

            string opcao = string.Empty;
            bool exibirMenu = true;

            //Realiza o loop do menu
            while (exibirMenu)
            {
                Console.Clear();
                System.Console.WriteLine("Digite a sua opção:");
                System.Console.WriteLine("1 - Cadastrar veículo");
                System.Console.WriteLine("2 - Remover veículo");
                System.Console.WriteLine("3 - Listar veículos");
                System.Console.WriteLine("4 - Encerrar");
                switch (Console.ReadLine())
                {
                    case "1":
                        estacionamento.AdicionarVeiculo();
                    break;
                    case "2":
                        estacionamento.RemoverVeiculo();
                    break;
                    case "3":
                        estacionamento.ListarVeiculos();
                    break;
                    case "4":
                        exibirMenu = false;
                    break;                    
                    default:
                        System.Console.WriteLine("Opção inválida");
                    break;
                }
                System.Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }
            System.Console.WriteLine("O programa se encerrou");
        }
    }
}

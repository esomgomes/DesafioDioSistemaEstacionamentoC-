using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora= 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        
        public void AdicionarVeiculo()
        {
            System.Console.WriteLine("Digite a placa do veículo para estacionar: ");
            veiculos.Add(Console.ReadLine());
        }
        public void RemoverVeiculo()
        {
            System.Console.WriteLine("Digite a placa do veículo para remover: ");
            string placa = Console.ReadLine();
            //Verificar se o veículo existe 
            if(veiculos.Any(x => x.ToUpper()==placa.ToUpper()))
            {
                System.Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                int horas = 0;
                decimal valorTotal = 0; 
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = Convert.ToDecimal(precoInicial + precoPorHora * horas);
                veiculos.Remove(placa);
                System.Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                System.Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }
        public void ListarVeiculos()
        {
            //Lista os veiculos estacionados
            if(veiculos.Any())
            {
                System.Console.WriteLine("Os veículos estacionados são: ");
                foreach (string veiculo in veiculos)
                {
                    System.Console.WriteLine(veiculo);
                }
            }
            else
            System.Console.WriteLine("Não há veículos estacionados.");
        }

    }
}
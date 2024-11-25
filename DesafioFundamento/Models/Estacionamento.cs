using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioFundamento.Models
{
    public class Estacionamento
    {
        private decimal valorInicial { get; set; }
        private decimal valorHora { get; set; }
        private List<Veiculo> veiculos { get; set; } = new List<Veiculo>();

        public Estacionamento(decimal valorInicial, decimal valorHora)
        {
            this.valorInicial = valorInicial;
            this.valorHora = valorHora;
        }

        public void adicionarVeiculo(string placa)
        {
            if (veiculos.Any(v => v.Placa == placa.ToUpper()))
            {
                Console.WriteLine("Já existe um veículo com essa placa no estacionamento");
            }
            else
            {
                veiculos.Add(new Veiculo(placa));
                Console.WriteLine($"Veículo {placa} adicionado ao estacionamento");
                Console.ReadKey();
            }
        }

        public void removerVeiculo(string placa)
        {
            var veiculo = veiculos.FirstOrDefault(v => v.Placa == placa.ToUpper());
            if (veiculo != null)
            {
                decimal valorTotal = veiculo.CalcularValor(valorInicial, valorHora);
                veiculos.Remove(veiculo);
                Console.WriteLine($"Veículo {placa} removido com sucesso");
                Console.WriteLine($"Tempo estacionado: {veiculo.TempoPermanencia().TotalMinutes:F1} minutos");
                Console.WriteLine($"Valor a pagar: R${valorTotal:F2}");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Veículo não encontrado no estacionamento");
            }
        }

        public void consultarVeiculos()
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Não há veículos no estacionamento.");
            }
            else
            {
                Console.WriteLine("Veículos no estacionamento:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"Placa: {veiculo.Placa} | Horário de entrada: {veiculo.HorarioEntrada}");
                }
                
            }
        Console.ReadKey();


        }
    }
}

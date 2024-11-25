using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamento.Models
{
   public class Veiculo
    {
        public string Placa { get; set; }
        public DateTime HorarioEntrada { get; private set; }

        public Veiculo(string placa)
        {
            Placa = placa.ToUpper();
            HorarioEntrada = DateTime.Now; 
        }

        public TimeSpan TempoPermanencia()
        {
            return DateTime.Now - HorarioEntrada;
        }

        public decimal CalcularValor(decimal valorInicial, decimal valorHora)
        {
            TimeSpan tempo = TempoPermanencia();
            int horas = (int)Math.Floor(tempo.TotalHours); 
            return valorInicial + (valorHora * horas);
        }
    }
}
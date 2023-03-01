using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PareAqui
{
    public class Ticket
    {
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public bool Ativo { get; set; }
        

        public Ticket()
        {
            Entrada = DateTime.Now;
            Ativo = true;
        }

        public double CalcularTempo()
        {
            var tempo = Saida - Entrada;
            return tempo.TotalMinutes;
        }

        public double CalcularValor()
        {
            return CalcularTempo() * 0.09;
        }
        
        public void FecharTicket()
        {
            Saida = DateTime.Now;
            Console.WriteLine($"O carro ficou {CalcularTempo()} minutos e o valor cobrado será de R$ {CalcularValor():C2}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PareAqui
{
    public class Carro
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public List<Ticket> ListaTickets { get; set; }


        public Carro()
        {
            ListaTickets = new List<Ticket>();
        }

           
    }
}
using System;
namespace Inicial.Models
{
    public class Comanda
    {
        public int ID { get; set; }
        public int idServico { get; set; }
        public int idCliente { get; set; }
        public string servico { get; set; }
        public double valorCo { get; set; }
    }
}
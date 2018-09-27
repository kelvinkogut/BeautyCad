using System;
namespace Inicial.Models
{
    public class ControleFin
    {
        public int ID { get; set; }
        public int IdServico { get; set; }
        public int IdCliente { get; set; }
        public decimal valoracrescimo { get; set; }
        public decimal valortotal { get; set; }
    }
}
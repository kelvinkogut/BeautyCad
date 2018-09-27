using System;
using System.Collections.Generic;

namespace Inicial.Models
{
    public class Horarios
    {
        public int ID { get; set; }
        public int idFuncionario { get; set; }
        public DateTime DataServico { get; set; }
        public string horarioinicio { get; set; }
        public string nomeFuncionario { get; set; }
        public int idCliente { get; set; }
        public int IdServico { get; set; }
        public int tempo { get; set; }

        public List<Servico> Servicos { get; set; }

        public Horarios()
        {
            Servicos = new List<Servico>();
        }
    }
}
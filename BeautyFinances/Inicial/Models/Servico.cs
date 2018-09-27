using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inicial.Models
{
    public class Servico
    {
        public int ID { get; set; }
        public string NomeServico { get; set; }
        public double duracao { get; set; }
        public string descricao { get; set; }
        public double valorservico { get; set; }

        public ICollection<Horarios> ListHorarios { get; set; }
        public Servico()
        {
            ListHorarios = new HashSet<Horarios>();
        }
        //[ForeignKey("ID")]
        //public virtual Horarios Horarios { get; set; }
    }
}
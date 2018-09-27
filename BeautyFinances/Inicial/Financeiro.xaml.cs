using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Inicial
{
    /// <summary>
    /// Lógica interna para Financeiro.xaml
    /// </summary>
    public partial class Financeiro : Window
    {
        public Financeiro()
        {
            InitializeComponent();
            using (var db = new ModelContext())
            {
                double valor = 0;
                int qtde = 0;
                foreach (var item in db.Horarios.Where(a => a.DataServico == DateTime.Today))
                {
                    foreach (var item2 in item.Servicos)
                    {
                        valor += item2.valorservico;
                        qtde++;
                    }
                }
                //var valorTotal = db.Horarios.Where(a => a.DataServico == DateTime.Today).Sum(a => a.Servicos.Sum(b => b.valorservico ));
                //var quantidade = db.Horarios.Where(a => a.DataServico == DateTime.Today).Sum(a => a.Servicos.Count());
            }
        }
    }
}

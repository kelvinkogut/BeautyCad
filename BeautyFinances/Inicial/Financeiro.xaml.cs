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
            using ( var db =  new ModelContext())
            {
                var lista = from f in db.ControleFins
                            join fc in db.Servicos on f.IdServico equals fc.ID
                            join cmd in db.Comandas on fc.ID equals cmd.idServico
                            where cmd.valorCo != 0.00
                            select cmd.valorCo ;
            }
        }
    }
}

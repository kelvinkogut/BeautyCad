using System.Windows;

namespace Inicial
{
    /// <summary>
    /// Lógica interna para Servicos.xaml
    /// </summary>
    public partial class Servicos : Window
    {
        public Servicos()
        {
            InitializeComponent();
        }

        private void btnAgen_Click(object sender, RoutedEventArgs e)
        {
            AgendaX ag = new AgendaX();
            ag.Show();
        }

        private void btnFinanceiro_Click(object sender, RoutedEventArgs e)
        {
            Financeiro fc = new Financeiro();
            fc.Show();
        }

        private void btnServ_Click(object sender, RoutedEventArgs e)
        {
            CadServico cs = new CadServico();
            cs.Show();
        }

        private void btnFunc_Click(object sender, RoutedEventArgs e)
        {
            Funcionarios fc = new Funcionarios();
            fc.Show();
        }
    }
}

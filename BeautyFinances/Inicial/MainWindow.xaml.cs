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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Inicial
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //chama forms cadastro
        private void btnCad_Click(object sender, RoutedEventArgs e)
        {
            Cadastro cd = new Cadastro();
            cd.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Servicos sv = new Servicos();
            sv.Show();
        }
    }
}

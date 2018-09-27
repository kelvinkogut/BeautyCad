using System.Linq;
using System.Windows;
namespace Inicial
{
    /// <summary>
    /// Lógica interna para ListaClientes.xaml
    /// </summary>
    public partial class ListaServicos : Window
    {
        public ListaServicos()
        {
            InitializeComponent();

            using (var db = new ModelContext())
            {
                lvServicos.ItemsSource = db.Servicos.ToList();
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


        }
    }
}

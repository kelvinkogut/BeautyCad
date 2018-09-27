using Inicial.Models;
using System.Collections.Generic;
using System.Windows;
namespace Inicial
{
    /// <summary>
    /// Lógica interna para ListaClientes.xaml
    /// </summary>
    public partial class ListaClientes : Window
    {
        public ListaClientes()
        {
            InitializeComponent();
            var usuario = new List<Cliente>();



            using (var db = new ModelContext())
            {

                foreach (var item in db.Clientes)
                {
                    usuario.Add(new Cliente()
                    {
                        Nome = item.Nome,
                        ciccgc = item.ciccgc,
                        endereco = item.endereco,
                        telefone = item.telefone
                    });
                    lvUsers.ItemsSource = usuario;
                }
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


        }
    }
}

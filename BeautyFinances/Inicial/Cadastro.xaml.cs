using System;
using System.Linq;
using System.Windows;

namespace Inicial
{
    /// <summary>
    /// Lógica interna para Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new ModelContext())
            {
                if (db.Clientes.Where(a => a.ciccgc == txtCPF.Text).Count() == 0)
                {
                    db.Clientes.Add(new Models.Cliente
                    {
                        Nome = txtNome.Text,
                        endereco = txtEndere.Text,
                        ciccgc = txtCPF.Text,
                        telefone = txtTele.Text,
                        sexo = txtSexo.Text,
                        UltimaVisita = DateTime.Today,
                        nascimento = Convert.ToDateTime(txtNascime.Text)
                    });

                    db.SaveChanges();

                    txtTele.Text = "";
                    txtSexo.Text = "";
                    txtNome.Text = "";
                    txtNascime.Text = "";
                    txtEndere.Text = "";
                    txtCPF.Text = "";
                    MessageBox.Show("Cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Cliente já existe!");
                }
            }
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            ListaClientes lc = new ListaClientes();
            lc.Show();
        }
    }
}

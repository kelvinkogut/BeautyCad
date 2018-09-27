using System;
using System.Windows;

namespace Inicial
{
    /// <summary>
    /// Interaction logic for CadServico.xaml
    /// </summary>
    public partial class CadServico : Window
    {
        public CadServico()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            ListaServicos ls = new ListaServicos();
            ls.Show();
        }

        private void btnCad_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                using (var db = new ModelContext())
                {
                    db.Servicos.Add(new Models.Servico()
                    {
                        NomeServico = txtNome.Text,
                        descricao = txtDesc.Text,
                        duracao = (int)udDuracao.Value,
                        valorservico = Convert.ToDouble(txtValor.Text),
                    });
                    db.SaveChanges();



                }
                //txtEnd.Text = "";
                //txtNasci.Text = "";
                //txtNome_.Text = "";
                MessageBox.Show("Cadastrado com sucesso!!!");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

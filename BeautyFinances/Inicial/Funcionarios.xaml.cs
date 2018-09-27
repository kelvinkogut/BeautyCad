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
    /// Lógica interna para Funcionarios.xaml
    /// </summary>
    public partial class Funcionarios : Window
    {
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            ListarFuncionario lf = new ListarFuncionario();
            lf.Show();
        }

        private void btnCad_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                using (var db = new ModelContext())
                {
                    db.Funcionarios.Add(new Models.Funcionarios()
                    {
                        nome = txtNome_.Text,
                        Funcao = cbxFuncao.Text,
                        dtaNascimento = Convert.ToDateTime(txtNasci.Text),
                        endereco = txtEnd.Text,
                        isAva = 1,
                        telefone = txtTelefone.Text
                    });
                    db.SaveChanges();



                }
                txtEnd.Text = "";
                txtNasci.Text = "";
                txtNome_.Text = "";
                MessageBox.Show("Cadastrado com sucesso!!!");
            }
            catch (Exception )
            {

                throw;
            }
        }
    }
}

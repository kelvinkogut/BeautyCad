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
using Inicial.Models;
namespace Inicial
{
    /// <summary>
    /// Lógica interna para ListarFuncionario.xaml
    /// </summary>
    public partial class ListarFuncionario : Window
    {
        public ListarFuncionario()
        {
            InitializeComponent();
            var func = new List<Models.Funcionarios>();

            using (var db = new ModelContext())
            {
                foreach (var item in db.Funcionarios)
                {
                    func.Add(new Models.Funcionarios()
                    {
                        nome = item.nome,
                        Funcao = item.Funcao,
                        telefone = item.telefone,
                        dtaNascimento = item.dtaNascimento
                        
                        
                    });
                    lvFunc.ItemsSource = func;
                }
            }
        }
    }
}

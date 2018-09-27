using Inicial.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace Inicial
{
    /// <summary>
    /// Lógica interna para AgendaX.xaml
    /// </summary>
    public partial class AgendaX : Window
    {
        private Horarios horarios = new Horarios();
        ObservableCollection<Servico> sourceServico = new ObservableCollection<Servico>();

        public AgendaX()
        {
            InitializeComponent();
            cldDia.DisplayDateStart = DateTime.Today;

            using (var db = new ModelContext())
            {
                cbFuncionario.ItemsSource = db.Funcionarios.ToList();
                cbCliente.ItemsSource = db.Clientes.ToList();
                cbServico.ItemsSource = db.Servicos.ToList();
            }
            lvServicos.ItemsSource = sourceServico;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (VerificaAgendamento())
            {
                using (var db = new ModelContext())
                {
                    db.Horarios.Add(new Horarios
                    {
                        idFuncionario = ((Models.Funcionarios)cbFuncionario.SelectedValue).ID,
                        idCliente = ((Cliente)cbCliente.SelectedValue).ID,
                        IdServico = ((Servico)cbServico.SelectedValue).ID,
                        Servicos = horarios.Servicos.ToList(),
                        DataServico = cldDia.SelectedDate.Value,
                        horarioinicio = tpHorario.Value.Value.Hour.ToString(),
                        tempo = (int)horarios.Servicos.Distinct().Sum(a => a.duracao)
                    });
                }
            }
        }

        private bool VerificaAgendamento()
        {
            if (cbFuncionario.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um funcionário");
                return false;
            }
            if (cbCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cliente");
                return false;
            }
            if (cbServico.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um serviço");
                return false;
            }
            return true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sourceServico.Add((Servico)cbServico.SelectedValue);
            lblTotal.Content = sourceServico.Sum(a => a.valorservico);
        }
    }
}

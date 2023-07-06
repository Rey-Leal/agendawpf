using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AgendaWpf
{
    /// <summary>
    /// Interaction logic for WpfContatos.xaml
    /// </summary>
    public partial class WpfContatos : Window
    {
        public WpfContatos()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Controle.Conecta();
                MessageBox.Show("Conectado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLocalizar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNovoContato_Click(object sender, RoutedEventArgs e)
        {
            WpfEdicaoContatos wpfEdicaoContatos = new WpfEdicaoContatos();
            wpfEdicaoContatos.ShowDialog();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

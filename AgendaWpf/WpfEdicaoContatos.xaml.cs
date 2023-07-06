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
using System.Windows.Shapes;

namespace AgendaWpf
{
    /// <summary>
    /// Interaction logic for WpfEdicaoContatos.xaml
    /// </summary>
    public partial class WpfEdicaoContatos : Window
    {
        public WpfEdicaoContatos()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int tipoInt;
                String tipoStr, nome, telefone, celular, email;
                if ((txtNome.Text != "") && (txtTelefone.Text != ""))
                {
                    tipoStr = cbxTipo.Text;
                    nome = txtNome.Text;
                    telefone = txtTelefone.Text;
                    celular = txtCelular.Text;
                    email = txtEmail.Text;
                    tipoInt = Controle.EnumDoTipo(tipoStr);
                    ContatoBO contatoBO = new ContatoBO(tipoInt, nome, telefone, celular, email);
                    String salva = Controle.SalvaContato(contatoBO);
                    MessageBox.Show(salva, Controle.NomeAplicacao(), MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Os campos nome e telefone são de preenchimento obrigatório!", Controle.NomeAplicacao(), MessageBoxButton.OK, MessageBoxImage.Information);
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Controle.NomeAplicacao(), MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            LimparCampos();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

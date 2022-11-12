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

namespace Libreria
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Libro libroInserito;

        private void btnLibro_Click(object sender, RoutedEventArgs e)
        {
             new Libro(txtTitolo.Text, txtAutore.Text,Int16.Parse(txtNumPagine.Text));   
            
        }
        
        private void btnIndiceLista_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnBiblioteca_Click(object sender, RoutedEventArgs e)
        {
            Biblioteca biblioteca = new Biblioteca(txtNomeB.Text, txtIndirizzo.Text, Convert.ToDouble(txtOrarioapertura.Text), Convert.ToDouble(txtorariochiusura.Text));
        }
    }
}

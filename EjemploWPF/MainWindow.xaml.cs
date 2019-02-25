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

namespace EjemploWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, RoutedEventArgs e)
        {
            LblWPF.Visibility = System.Windows.Visibility.Hidden;
            TxtBlock.Visibility = System.Windows.Visibility.Visible;
            btnAccion2.Visibility = System.Windows.Visibility.Hidden;
        }
        private void btnAccion2_Click(object sender, RoutedEventArgs e)
        {
            LblWPF.Visibility = System.Windows.Visibility.Visible;
            TxtBlock.Visibility = System.Windows.Visibility.Hidden;

        }
    }
}

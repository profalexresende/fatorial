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

namespace fatorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFatorial_Click(object sender, RoutedEventArgs e)
        {
            double num, fat=1;
            int cont = 1;

            num = Convert.ToDouble(txtNumero.Text);

            while (cont <= num)
            {
                fat = fat * cont;
                cont++;
            }
            lblResultado.Content = fat.ToString();
        }
    }
}

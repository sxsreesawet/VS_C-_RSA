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

namespace RSA_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ulong N = 0;
        ulong P = 0;
        ulong Q = 0;
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "RSA Encryption";
        }

        private void txtP1_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool P_numeric = ulong.TryParse(txtP1.Text, out P);
            if (P_numeric)
            {
                bool Q_numeric = ulong.TryParse(txtP2.Text, out Q);
                if (Q_numeric)
                {
                    N = P * Q;
                    cmdGenerate.IsEnabled = true;
                    lbl1.Content = "drop up allow";
                }
                else
                {
                    cmdGenerate.IsEnabled = false;
                    lbl1.Content = "Please Enter a Prime number";
                }
            }
            else
            {
                cmdGenerate.IsEnabled = false;
                lbl1.Content = "Please Enter a Prime number";
            }
                
        }



        private void txtP2_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool Q_numeric = ulong.TryParse(txtP2.Text, out Q);
            if (Q_numeric)
            {
                bool P_numeric = ulong.TryParse(txtP1.Text, out P);
                if (P_numeric)
                {
                    N = P * Q;
                    cmdGenerate.IsEnabled = true;
                    lbl1.Content = "drop down allow";
                }
                else
                {
                    cmdGenerate.IsEnabled = false;
                    lbl1.Content = "Please Enter a Prime number";
                }
            }
            else
            {
                cmdGenerate.IsEnabled = false;
                lbl1.Content = "Please Enter a Prime number";
            }
            
        }

        private void cmdGenerate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

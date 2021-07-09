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

namespace WpfHW1
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

        private void ex1Button_Click(object sender, RoutedEventArgs e)
        {
            Ex1 ex1 = new Ex1();
            ex1.ShowDialog();
        }

        private void ex2Button_Click(object sender, RoutedEventArgs e)
        {
            Ex2 ex2 = new Ex2();
            ex2.ShowDialog();
        }
    }
}

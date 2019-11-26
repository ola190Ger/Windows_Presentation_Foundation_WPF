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

namespace dz1_текстовый_редактор
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CUT_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Cut();
        }

        private void COPY_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Copy();
        }

        private void PASTE_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Paste();
        }
    }
}

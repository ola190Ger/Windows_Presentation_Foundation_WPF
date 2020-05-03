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

namespace WPF_HW2_Keyboard_simulator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement c in GRID.Children)
            {
                if (c is Button)
                {
                    ((Button)c).Click += Button_Click;
                }
            }

        }
        void Caps_Click(object sender, RoutedEventArgs e)
        {
            foreach (UIElement c in GRID.Children)
            {
                //foreach(UIElement btn in c.)
                //{
                //    ((Button)btn).Content = ((Button)e.OriginalSource).Content.ToString().ToUpper();
                //}
            }
        }
        void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = (string)((Button)e.OriginalSource).Content;
            TB.Text += s;
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
        }
    }
}

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

namespace dz1_3_убегающая_кнока
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

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.GetPosition(null).X > 0 && e.GetPosition(null).X < btn.Margin.Left + 10) && (e.GetPosition(null).Y > 0 && e.GetPosition(null).Y < btn.Margin.Top + 10+btn.ActualHeight))
            {
                //e.GetPosition(null) = new Point(e.GetPosition(null).X + rnd.Next(-10, 10), e.GetPosition(null).Y + rnd.Next(-10, 10));
                btn.Margin = new Thickness(btn.Margin.Left + 10, btn.Margin.Top, 0, 0);
            }
            // /*
            else if ((e.GetPosition(null).X <= 0 || e.GetPosition(null).X >= btn.Margin.Left + 10) && (e.GetPosition(null).Y > 0 && e.GetPosition(null).Y < btn.Margin.Top + 10+btn.ActualHeight))
            {
                //label1.Location = new Point(e.GetPosition(null).X, e.GetPosition(null).Y + rnd.Next(-10, 10));
                btn.Margin = new Thickness(btn.Margin.Left, btn.Margin.Top + 10, 0, 0);

            }
            else
            if ((e.GetPosition(null).X > 0 && e.GetPosition(null).X < btn.Margin.Left - 10) && (e.GetPosition(null).Y <= 0 || e.GetPosition(null).Y >= btn.Margin.Top + 10+btn.ActualHeight))
            {
                //label1.Location = new Point(e.GetPosition(null).X + rnd.Next(-10, 10), e.GetPosition(null).Y);
                btn.Margin = new Thickness(btn.Margin.Left + 20, btn.Margin.Top, 0, 0);

            }
            //if ((e.GetPosition(null).X <= 0 || e.GetPosition(null).X >= btn.Margin.Left+10) && (e.GetPosition(null).Y <= 0 || e.GetPosition(null).Y >= btn.Margin.Top + 10))
           // {
               // MessageBox.Show("You Catch me ;(", "It`s all");
           // }

        }


    }
}

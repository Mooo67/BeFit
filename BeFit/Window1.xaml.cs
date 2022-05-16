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

namespace BeFit
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        public void Button_Click1(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            var myForm = new BeFit.Kunden();
            myForm.Show();
        }

        public void Button_Click2(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            var myForm = new BeFit.Trainingsplan();
            myForm.Show();
        }

        public void Button_Click3(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            var myForm = new BeFit.Nährstoffberechnung();
            myForm.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            var myForm = new BeFit.BMI_Rechner();
            myForm.Show();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            var myForm = new BeFit.Erstgespräch();
            myForm.Show();
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
        //Support
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            //Logout
            this.Visibility = Visibility.Hidden;
            string message = "Ausgeloggt";
            MessageBox.Show(message);
            this.Close();
        }
    }
}

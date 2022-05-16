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
    /// Interaktionslogik für BMI_Rechner.xaml
    /// </summary>
    public partial class BMI_Rechner : Window
    {
        private string alter;
        private string Körpergröße;
        private string Körpergewicht;
        private double Ergebniss;

        public BMI_Rechner()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            alter = Alterbox.Text;
            Körpergewicht = KörpergewichtBox.Text;
            Körpergröße = KörpergrößeBox.Text;

            int value = int.Parse(alter);
            double value1 = double.Parse(Körpergröße);
            double value2 = double.Parse(Körpergewicht);

            Ergebniss= value2 /(value1*value1) ;

            ErgebnissLabel.Content = Ergebniss;

            
        }

        private void Alterbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

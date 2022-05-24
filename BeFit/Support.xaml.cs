using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
    /// Interaktionslogik für Support.xaml
    /// </summary>
    public partial class Support : Window
    {
        public Support()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add("lxq70599@jiooq.com"); // Empfänger Email
                mail.From = new MailAddress("hopsporjektsuppo@gmail.com"); // Absender
                mail.Subject = "Support!";
                mail.Body = txt.Text;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("hopsporjektsuppo@gmail.com", "Hundesohn1"); // Absender und passwort
                smtp.Send(mail);
                MessageBox.Show("E-Mail verschickt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        }
    }


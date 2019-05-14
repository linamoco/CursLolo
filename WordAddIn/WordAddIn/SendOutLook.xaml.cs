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
using System.IO;

namespace WordAddIn
{
    /// <summary>
    /// Логика взаимодействия для SendOutLook.xaml
    /// </summary>
    public partial class SendOutLook : Window
    {
        public SendOutLook()
        {
            InitializeComponent();
        }
      

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.ClearEffect(this);
            var a = !MainWindow.OutSave ? button1.Background = new SolidColorBrush(Color.FromArgb(147, 226, 234, 100)) : button1.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            //var b = !telFlag ? TelegramCheckButton.: TelegramCheckButton.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            MainWindow.OutSave = !MainWindow.OutSave;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.ClearEffect(this);
            var a = !MainWindow.OutSend ? button2.Background = new SolidColorBrush(Color.FromArgb(147, 226, 234, 100)) : button2.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            //var b = !telFlag ? TelegramCheckButton.: TelegramCheckButton.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            MainWindow.OutSend = !MainWindow.OutSend;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("themaTxt.txt", false))
            {
                sw.WriteLine(thema.Text);
            }
            this.Close();
        }
    }
}

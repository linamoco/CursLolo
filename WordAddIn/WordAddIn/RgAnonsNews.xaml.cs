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
    /// Логика взаимодействия для RgAnonsNews.xaml
    /// </summary>
    public partial class RgAnonsNews : Window
    {
        public RgAnonsNews()
        {
            InitializeComponent();

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void anons_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.rgNew = true;
            using (StreamWriter sw = new StreamWriter("titleRgNews.txt", false))
            {
                sw.WriteLine(title.Text);
            }
            using (StreamWriter sw = new StreamWriter("nameProjectRg.txt", false))
            {
                sw.WriteLine(nameProject.Text);
            }
            this.Close();

        }
    }
}

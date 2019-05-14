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
    /// Логика взаимодействия для WindowTelegram.xaml
    /// </summary>
    public partial class WindowTelegram : Window
    {
        public WindowTelegram()
        {
            InitializeComponent();
            //System.IO.File.WriteAllText("D:\\TestFile.txt", "текст");
            //StreamWriter file = new StreamWriter("D:\\TestFile.txt");
            try
            {
                using (StreamReader sw = new StreamReader("namechanell.txt"))
                {
                    string s = sw.ReadLine();
                    if (s != null)
                        nameCha.Text = s;
                }
            }
            catch { string fileName = System.IO.Path.Combine(Environment.CurrentDirectory, "namechanell.txt"); }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.IO.File.WriteAllText("namechanell.txt", nameCha.Text);
            //using (StreamWriter sw = new StreamWriter("namechanell.txt", false))
            //{
            //    sw.WriteLine(nameCha.Text);
            //}
            SaveMessageBox objModal = new SaveMessageBox();
            objModal.Owner = this;
            MainWindow.ApplyEffect(this);

            objModal.ShowDialog();

            MainWindow.ClearEffect(this);
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

    }
}

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
    /// Логика взаимодействия для RGWindow.xaml
    /// </summary>
    public partial class RGWindow : Window
    {
        public RGWindow()
        {
            InitializeComponent();

            try
            {
                using (StreamReader sw = new StreamReader("loginRg.txt"))
                {
                    string s = sw.ReadLine();
                    if (s != null)
                        loginRG.Text = s;
                }
            }
            catch { string fileName = System.IO.Path.Combine(Environment.CurrentDirectory, "loginRg.txt.txt"); }

            try
            {
                using (StreamReader sw = new StreamReader("passwordRg.txt"))
                {
                    string s = sw.ReadLine();
                    if (s != null)
                        passwordRG.Text = s;
                }
            }
            catch { string fileName = System.IO.Path.Combine(Environment.CurrentDirectory, "passwordRg.txt"); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //System.IO.File.WriteAllText("loginHSE.txt", loginHSE.Text);
            using (StreamWriter sw = new StreamWriter("loginRg.txt", false))
            {
                sw.WriteLine(loginRG.Text);
            }
            //System.IO.File.WriteAllText("passwordHSE.txt", passwordHse.Text);
            using (StreamWriter sw = new StreamWriter("passwordRg.txt", false))
            {
                sw.WriteLine(passwordRG.Text);
            }
            SaveMessageBox objModal = new SaveMessageBox();
            objModal.Owner = this;
            MainWindow.ApplyEffect(this);

            objModal.ShowDialog();

            MainWindow.ClearEffect(this);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

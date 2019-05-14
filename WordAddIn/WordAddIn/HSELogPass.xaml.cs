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
    /// Логика взаимодействия для HSELogPass.xaml
    /// </summary>
    public partial class HSELogPass : Window
    {
        public HSELogPass()
        {
            InitializeComponent();
            try
            {
                using (StreamReader sw = new StreamReader("loginHSE.txt"))
                {
                    string s = sw.ReadLine();
                    if (s != null)
                        loginHSE.Text = s;
                }
            }
            catch { string fileName = System.IO.Path.Combine(Environment.CurrentDirectory, "loginHSE.txt.txt"); }

            try
            {
                using (StreamReader sw = new StreamReader("passwordHSE.txt"))
                {
                    string s = sw.ReadLine();
                    if (s != null)
                        passwordHse.Text = s;
                }
            }
            catch { string fileName = System.IO.Path.Combine(Environment.CurrentDirectory, "passwordHSE.txt"); }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //System.IO.File.WriteAllText("loginHSE.txt", loginHSE.Text);
            using (StreamWriter sw = new StreamWriter("loginHSE.txt", false))
            {
                sw.WriteLine(loginHSE.Text);
            }
            //System.IO.File.WriteAllText("passwordHSE.txt", passwordHse.Text);
            using (StreamWriter sw = new StreamWriter("passwordHSE.txt", false))
            {
                sw.WriteLine(passwordHse.Text);
            }
            SaveMessageBox objModal = new SaveMessageBox();
            objModal.Owner = this;
            MainWindow.ApplyEffect(this);

            objModal.ShowDialog();

            MainWindow.ClearEffect(this);
        }
    }
}

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

namespace WordAddIn
{
    /// <summary>
    /// Логика взаимодействия для MessSaveBox.xaml
    /// </summary>
    public partial class MessSaveBox : Window
    {
        public MessSaveBox()
        {
            InitializeComponent();
        }
        public MessSaveBox(string message)
        {
            this.message.Text = message;
            InitializeComponent();
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

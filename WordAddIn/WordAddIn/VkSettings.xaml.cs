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
    /// Логика взаимодействия для VkSettings.xaml
    /// </summary>
    public partial class VkSettings : Window
    {
        public VkSettings()
        {
            InitializeComponent();
            MainWindow.check = false;
        }

        private void Exit_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!MainWindow.check)
            {
                MainWindow.data = data.Text;
                MainWindow.time = time.Text;
            }
            this.Close();
            
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            data.Visibility = Visibility.Collapsed;
            time.Visibility = Visibility.Collapsed;
            block1.Visibility = Visibility.Collapsed;
            bloсk2.Visibility = Visibility.Collapsed;
            DataTimeVk();
            MainWindow.check = true;

        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            data.Visibility = Visibility.Visible;
            time.Visibility = Visibility.Visible;
            block1.Visibility = Visibility.Visible;
            bloсk2.Visibility = Visibility.Visible;
            MainWindow.check = false;
        }

        private void DataTimeVk()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            //date.AddMinutes(1000.0);
            string[] DT = date.ToString().Split();
            string[] Data = DT[0].Split('.');
            string[] Time = DT[1].Split(':');
            DateTime dateValue = new DateTime(int.Parse(Data[2]), int.Parse(Data[1]), int.Parse(Data[0]), int.Parse(Time[0]), int.Parse(Time[1]), int.Parse(Time[2]));

            dateValue = dateValue.AddMinutes(10);
            Console.WriteLine(dateValue);
            DT = dateValue.ToString().Split();
            Data = DT[0].Split('.');
            Time = DT[1].Split(':');
            string time = Time[0] + ":" + Time[1];
            if (Data[1][0] == '0')
            {
                Data[1] = Data[1][1].ToString();
            }
            string data = Data[2] + " " + Data[1] + " " + Data[0];


            MainWindow.time = time;
            MainWindow.data = data;
        }

       
    }
}

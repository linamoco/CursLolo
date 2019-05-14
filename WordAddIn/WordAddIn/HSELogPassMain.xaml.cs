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
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.IO;

namespace WordAddIn
{
    /// <summary>
    /// Логика взаимодействия для HSELogPassMain.xaml
    /// </summary>
    public partial class HSELogPassMain : Window
    {
        public HSELogPassMain()
        {
            InitializeComponent();
        }
        string Text { get; set; }
        public HSELogPassMain(string text)
        {
            InitializeComponent();
            Text = text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void anons_Click(object sender, RoutedEventArgs e)
        {
            string login;
            string pass;
            using (StreamReader sw = new StreamReader("loginHSE.txt"))
            {
                login = sw.ReadLine();
            }
            using (StreamReader sw = new StreamReader("passwordHSE.txt"))
            {
                pass = sw.ReadLine();
            }

            IWebDriver driver = new ChromeDriver();

            try
            {
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                driver.Navigate().GoToUrl("https://www.hse.ru/adm/edit/edit.html?ou=133639679&newportal=1&goto=%2AL2FkbS9vcmcvc3RydWN0dXJlLzEzMzYzOTY3OS9hbm5vdW5jZW1lbnRzL2luZGV4Lmh0bWw%2FX3I9%5EMTc5MTAxNTU3NzYwMjQ4LjUyODc2Jm5ld3BvcnRhbD0x%5E&cid=20063&addon_name=default");
                driver.FindElement(By.Id("lform_login")).SendKeys(login);
                //System.Threading.Thread.Sleep(500);
                driver.FindElement(By.Id("lform_password")).SendKeys(pass);
                driver.FindElement(By.CssSelector("input.mdn-button")).Click();
                driver.SwitchTo().Frame(2);
                driver.FindElement(By.Id("tinymce")).SendKeys(Text);
            }
            catch (OpenQA.Selenium.NoSuchFrameException) { }
            catch { }
            this.Close();
        }

        private void news_Click(object sender, RoutedEventArgs e)
        {
            string login;
            string pass;
            using (StreamReader sw = new StreamReader("loginHSE.txt"))
            {
                login = sw.ReadLine();
            }
            using (StreamReader sw = new StreamReader("passwordHSE.txt"))
            {
                pass = sw.ReadLine();
            }

            //string newText = new TextRange(MainWindow.richTextBox1.Document.ContentStart, richTextBox1.Document.ContentEnd).Text;
            try
            {
                IWebDriver driver = new ChromeDriver();

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                driver.Navigate().GoToUrl("https://www.hse.ru/adm/edit/edit.html?ou=133639679&newportal=1&goto=%2AL2FkbS9vcmcvc3RydWN0dXJlLzEzMzYzOTY3OS9uZXdzL2luZGV4Lmh0bWw%2FX3I9MjQxODIxNTU3%5EMjQ1NzYwLjA4NzQzJm5ld3BvcnRhbD0x%5E&cid=20045&addon_name=default");
                driver.FindElement(By.Id("lform_login")).SendKeys(login);

                driver.FindElement(By.Id("lform_password")).SendKeys(pass);
                driver.FindElement(By.CssSelector("input.mdn-button")).Click();
                driver.SwitchTo().Frame(2);
                driver.FindElement(By.Id("tinymce")).SendKeys(Text);
            }
            catch (OpenQA.Selenium.WebDriverException) { }
            
            catch{ }
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using Vkontakte;
using table;
using System.IO;
using System.Net;
using Telegram.Bot;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.Collections.Specialized;

namespace WordAddIn
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static internal bool OutSend = false;
        static internal bool OutSave = false;
        string Text { get; set; }

        public MainWindow(string s)
        {
            InitializeComponent();
            Text = s;
            FlowDocument document = new FlowDocument();
            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add(new Bold(new Run(Text)));
            document.Blocks.Add(paragraph);
            richTextBox1.Document = document;
        }
        public MainWindow()
        {
            InitializeComponent();
            FlowDocument document = new FlowDocument();
            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add(new Bold(new Run(Text)));
            document.Blocks.Add(paragraph);
            richTextBox1.Document = document;
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

      
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            MainControl.SelectedIndex = 0; 
        }
        private void SendButton_Copy5_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SendButton_Copy1_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("tt");
        }
        bool telFlag = false;
        bool vkFlag = false;
        bool hseFlag = false;
        bool outFlag = false;
        bool rgFlag = false;

        internal static bool rgAnons = false;
        internal static bool rgNew = false;
        private void SendButton_Copy4_Click(object sender, RoutedEventArgs e)
        {
            RgAnonsNews objModal = new RgAnonsNews();
            objModal.Owner = this;
            MainWindow.ApplyEffect(this);

            objModal.ShowDialog();

            MainWindow.ClearEffect(this);

            var a = !rgFlag ? ResearchGate.Background = new SolidColorBrush(Color.FromArgb(147, 226, 234, 100)) : ResearchGate.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            //var b = !telFlag ? TelegramCheckButton.: TelegramCheckButton.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            rgFlag = !rgFlag;
        }


        private void TelegramCheckButton_Click_1(object sender, RoutedEventArgs e)
        {
            var a = !telFlag ? TelegramCheckButton.Background = new SolidColorBrush(Color.FromArgb(147, 226, 234, 100)) : TelegramCheckButton.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            //var b = !telFlag ? TelegramCheckButton.: TelegramCheckButton.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            telFlag = !telFlag;
        }
        internal static bool check = false;
        private void Vkontakte_Click(object sender, RoutedEventArgs e)
        {
            var a = !vkFlag||check ? vkontakte.Background = new SolidColorBrush(Color.FromArgb(147, 226, 234, 100)) : vkontakte.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            //var b = !telFlag ? TelegramCheckButton.: TelegramCheckButton.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            vkFlag = !vkFlag;
            VkSettings objModal = new VkSettings();
            objModal.Owner = this;
            MainWindow.ApplyEffect(this);

            objModal.ShowDialog();

            MainWindow.ClearEffect(this);
        }


        private void Hse_Click(object sender, RoutedEventArgs e)
        {
            string newText = new TextRange(richTextBox1.Document.ContentStart, richTextBox1.Document.ContentEnd).Text;
            HSELogPassMain objModal = new HSELogPassMain(newText);
            
            objModal.Owner = this;
            MainWindow.ApplyEffect(this);

            objModal.ShowDialog();

            MainWindow.ClearEffect(this);
        }

        private void OutLook_Click(object sender, RoutedEventArgs e)
        {
            OutSave = OutSend = false;
            SendOutLook objModal = new SendOutLook();
            objModal.Owner = this;
            MainWindow.ApplyEffect(this);

            objModal.ShowDialog();

            MainWindow.ClearEffect(this);
            var a = OutSend|OutSave ? OutLook.Background = new SolidColorBrush(Color.FromArgb(147, 226, 234, 100)) : OutLook.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            //var b = !telFlag ? TelegramCheckButton.: TelegramCheckButton.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            outFlag = !outFlag;
        }
        string way;


        private void SendButton_Copy6_Click(object sender, RoutedEventArgs e)
        {
            var fileDialog = new System.Windows.Forms.OpenFileDialog();
            var result = fileDialog.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                var file = fileDialog.FileName;
                TxtFile.Text = file;
                way = file;
                TxtFile.ToolTip = file;        
            }
            else
            {
                TxtFile.Text = null;
                TxtFile.ToolTip = null;
            }
        }
        static ITelegramBotClient botClient;
        protected static string tokenTelegram = "861879980:AAHlhxjh6YncToyBNjtSM45cF9YZeqiSdD4";
        protected static string nameCanal;
        internal bool flag = false;
        internal static  string time { get; set; }
        internal static string data { get; set; }
        private void SendMain_Click(object sender, RoutedEventArgs e)
        {

            //получить текст из richtextbox
            string newText = new TextRange(richTextBox1.Document.ContentStart, richTextBox1.Document.ContentEnd).Text;
            if (telFlag)
            {
                using (StreamReader sw = new StreamReader("namechanell.txt"))
                {
                    nameCanal = sw.ReadLine();
                }
                //отправляем в телеграм
                //861879980:AAHlhxjh6YncToyBNjtSM45cF9YZeqiSdD4
                botClient = new TelegramBotClient(tokenTelegram);
                //botClient.SendPhotoAsync("@diejdkekr", photoHeaderDispData);
                try
                {
                    FileStream fstream = System.IO.File.OpenRead(way);

                    Telegram.Bot.Types.InputFiles.InputOnlineFile t = new Telegram.Bot.Types.InputFiles.InputOnlineFile(fstream, TxtFile.Text);
                    //https://t.me/voronenokhse
                    botClient.SendPhotoAsync(nameCanal, t, newText);
                    flag = true;
                }
                catch (System.ArgumentNullException)
                {
                    string url = "https://api.telegram.org/bot" + tokenTelegram + "/sendMessage";

                    using (var webClient = new WebClient())
                    {
                        // Создаём коллекцию параметров
                        var pars = new NameValueCollection();

                        // Добавляем необходимые параметры в виде пар ключ, значение
                        pars.Add("text", newText);
                        pars.Add("chat_id", nameCanal);
                        // Посылаем параметры на сервер
                        // Может быть ответ в виде массива байт
                        try
                        {
                            var response = webClient.UploadValues(url, pars);
                            flag = true;
                        }
                        catch (Exception ex)
                        {
                            System.Windows.MessageBox.Show("Нельзя отправить полностью пустое сообщение\n" + ex.Message);
                        }
                    }
                }
                catch
                {
                    System.Windows.MessageBox.Show("ошибка");
                }
            }

            if (vkFlag)
            {
                //try
                //{
                //отправляем в ВК
                try
                {
                    var VkClass = new vkWallPost("ae363f8388210268830659859871e929f4ceb3976839d856b8aedf8d7ce812b1bd9100ede063380ab1070");
                    string result = VkClass.AddWallPost(-180723519, newText, TxtFile.Text, time, data);
                    System.Windows.Forms.MessageBox.Show(result);

                    //"""в это время уже было отправлено"" сделать месседжбокс
                    string ch = "for this time";
                    int indexOfChar = result.IndexOf(ch);
                    if (result == "Error")
                        throw (new Exception("Нельзя отправлять полностью пустое сообщение"));
                    flag = true;
                }
                catch (System.Net.WebException)
                {
                    System.Windows.MessageBox.Show("Нет подключения к сети");
                }

                //}
                //catch (Exception ex)
                //{
                //    System.Windows.MessageBox.Show(ex.Message);
                //}
            }
            //отправка в OutLook
            string listOfPost = "";
            if (outFlag || OutSave || OutSend)
            {
                //try{
                Microsoft.Office.Interop.Outlook._Application _app = new Microsoft.Office.Interop.Outlook.Application();
                Microsoft.Office.Interop.Outlook.MailItem mail = (Microsoft.Office.Interop.Outlook.MailItem)_app.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
                using (StreamReader sw = new StreamReader("OutLookTxt.txt"))
                {
                    string s = sw.ReadLine();
                    while (s != "" && s != null)
                    {
                        listOfPost += s + ";";
                        s = sw.ReadLine();
                    }
                }
                listOfPost = listOfPost.Substring(0, listOfPost.Length - 1);
                mail.To = listOfPost;
                using (StreamReader sw = new StreamReader("themaTxt.txt"))
                {
                    string s = sw.ReadLine();
                    mail.Subject = s;
                }
                mail.Body = newText;
                mail.Importance = Microsoft.Office.Interop.Outlook.OlImportance.olImportanceNormal;
                try
                {
                    mail.Attachments.Add(TxtFile.Text, Microsoft.Office.Interop.Outlook.OlAttachmentType.olByValue, 1, "Няяяяяяя");
                }
                catch (DirectoryNotFoundException) { }

                //}
                //catch (Exception ex)
                //{
                //    System.Windows.MessageBox.Show(ex.Message, "Ошибка");
                //}
                flag = true;
                if (OutSave)
                {
                    mail.Save();
                }
                else
                {
                    mail.Send();
                }


            }
            if (rgNew)
            {
                string titlerg;
                using (StreamReader sw = new StreamReader("titleRgNews.txt"))
                {
                    titlerg = sw.ReadLine();
                }

                var options = new ChromeOptions();
                options.AddArguments("headless");
                using (IWebDriver driver = new ChromeDriver(options))
                {
                    
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                    driver.Navigate().GoToUrl("https://www.researchgate.net/project/TestPro/update/create");
                    driver.FindElement(By.Id("input-login")).SendKeys("avbrazhnikova@edu.hse.ru");
                    //System.Threading.Thread.Sleep(500);
                    driver.FindElement(By.Id("input-password")).SendKeys("fynbakee1");
                    driver.FindElement(By.CssSelector("button.nova-c-button")).Click();
                    driver.FindElement(By.Id("field-title")).SendKeys(titlerg);
                    driver.FindElement(By.CssSelector("div.converse-editor__input")).Click();
                    Actions action = new Actions(driver);
                    action.SendKeys(newText).Build().Perform();
                    driver.FindElement(By.CssSelector("button.nova-c-button[type='submit']")).Click();
                    rgNew = false;
                }
                if (rgAnons)
                {
                    rgAnons = false;
                }
                if (flag)
                {
                    MessSaveBox objModal = new MessSaveBox();
                    objModal.Owner = this;
                    ApplyEffect(this);
                    objModal.ShowDialog();
                    ClearEffect(this);

                }
            }
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            MainControl.SelectedIndex = 1;
        }

        private void settings_Click(object sender, RoutedEventArgs e)
        {
            MainControl.SelectedIndex = 2;
        }
        
        private void TelegramSettings_Click(object sender, RoutedEventArgs e)
        {
            WindowTelegram objModal = new WindowTelegram();
            objModal.Owner = this;
            ApplyEffect(this);

            objModal.ShowDialog();

            ClearEffect(this);
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void out_Click(object sender, RoutedEventArgs e)
        {
            Form1 forma = new Form1();
            forma.Show();
        }

        private void SendButton_Copy7_Click(object sender, RoutedEventArgs e)
        {
            //MessBox objModal = new MessBox();
            //objModal.Owner = this;
            //ApplyEffect(this);

            //objModal.ShowDialog();

            //ClearEffect(this);

        }
        /// <summary>
        /// Apply Blur Effect on the window
        /// </summary>
        /// <param name=”win”></param>
        static internal void ApplyEffect(Window win)
        {
            System.Windows.Media.Effects.BlurEffect objBlur = new System.Windows.Media.Effects.BlurEffect();
            objBlur.Radius = 4;
            win.Effect = objBlur;
        }

        /// <summary>
        /// Remove Blur Effects
        /// </summary>
        /// <param name=”win”></param>
        static internal void ClearEffect(Window win)
        {
            win.Effect = null;
        }

        private void VkSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void HSE_Settings_Click(object sender, RoutedEventArgs e)
        {
            HSELogPass objModal = new HSELogPass();
            objModal.Owner = this;
            MainWindow.ApplyEffect(this);

            objModal.ShowDialog();

            MainWindow.ClearEffect(this);
        }

        private void rgSettings_Click(object sender, RoutedEventArgs e)
        {
            RGWindow objModal = new RGWindow();
            objModal.Owner = this;
            MainWindow.ApplyEffect(this);

            objModal.ShowDialog();

            MainWindow.ClearEffect(this);
        }
    }
}

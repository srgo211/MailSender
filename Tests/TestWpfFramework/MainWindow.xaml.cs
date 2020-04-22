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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestWpfFramework
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sendToEmail_Click(object sender, RoutedEventArgs e)
        {


            // отправитель - он же логин от почты
            //string from = userName.Text;
            //пароль
            //string passToEmail = password.Password;

            // кому отправляем
            string to = "evgeniyzhuravlyov2000018dwh@rambler.ua";


            try
            {
                // создаем объект сообщения
                using (MailMessage msg = new MailMessage(from, to))
                {
                    msg.Subject = "Тема сообщения от" + DateTime.Now;
                    msg.Body = "Текст сообщения: " + DateTime.Now;
                    msg.IsBodyHtml = false;

                    // адрес smtp-сервера и порт, с которого будем отправлять письмо
                    using (SmtpClient smtp = new SmtpClient())
                    {
                        /*
                         * настройки для рамблер почты
                         * если используем шифрование (рекомендуется) то порт ставим 465
                         * p.s. свежереги сначала не поддерживует шифрование - поэтому порт 25 или 465
                         */
                        smtp.Host = "smtp.rambler.ru";
                        smtp.Port = 25; //порт
                        smtp.EnableSsl = false; // не используем шифрование
                        smtp.Credentials = new System.Net.NetworkCredential(from, passToEmail); //проверка учетной записи логин и пароль от почты

                        smtp.Send(msg);

                        MessageBox.Show("Почта отправлена", "Успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("ОШИБКА", error.Message, MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }








    }//public partial class MainWindow
}//namespace TestWpfFramework

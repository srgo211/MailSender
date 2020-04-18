using LibMailSender.Data;
using LibMailSender.Entities;
using System.Windows;

namespace MailSender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            SendersList.ItemsSource = TestData.ListSenders;

        }

        private void btnSendClick(object sender, RoutedEventArgs e)
        {
            //извлекаем данные
            var recipient = RecipientsList.SelectedItem as Recipient;
            //получаем данные отправителя
            var senders = SendersList.SelectedItem as Sender;
            //получаем данные сервера
            var server = ServersList.SelectedItem as Server;

            //проверка
            if (recipient is null || senders is null || server is null) return;

            var emailSend = new LibMailSender.Modules.MailSender(server.AddressSMTP, server.Port, server.UseSSL,server.LoginToEmail,server.PasswordToEmail);

            emailSend.Send(MailHeader.Text,MailBody.Text,senders.AddressToEmail,recipient.AddressToEmail);
        
        
        }
        /// <summary>
        /// Клик Редактировать отправителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditClick(object sender, RoutedEventArgs e)
        {
            //получаем данные отправителя
            var senders = SendersList.SelectedItem as Sender;
            if (senders is null) return;

            var dialog = new SenderEditor(senders);

            if (dialog.ShowDialog() !=true) return;

            senders.Name = dialog.Name;
            senders.AddressToEmail = dialog.AdresValue;



        }
    }   
}

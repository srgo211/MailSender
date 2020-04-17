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
            //извлекаем данные получателей писем
            var recipient = RecipientsList.SelectedItem as Recipient;
            var senders = SendersList.SelectedItem as Sender;
            var server = ServersList.SelectedItem as Server;

            //проверка
            if (recipient is null || senders is null || server is null) return;

            var emailSend = new LibMailSender.Modules.MailSender(server.AddressSMTP, server.Port, server.UseSSL,server.LoginToEmail,server.PasswordToEmail);

            emailSend.Send(MailHeader.Text,MailBody.Text,senders.AddressToEmail,recipient.AddressToEmail);
        
        
        }
    }   
}

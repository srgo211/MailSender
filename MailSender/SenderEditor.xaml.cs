using LibMailSender.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MailSender
{
    
    /// <summary>
    /// Логика взаимодействия для SenderEditor.xaml
    /// </summary>
    public partial class SenderEditor
    {
        public string NameValue { get => NameEditSender.Text; set => NameEditSender.Text = value;}
        public string AdresValue { get => AdressEditSender.Text; set => AdressEditSender.Text = value; }


        public SenderEditor(Sender Sender )
        {
            InitializeComponent();
            NameValue = Sender.Name;
            AdresValue = Sender.AddressToEmail;
        }

        private void btnSenderEditOkClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void btnSenderEditCanselClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}

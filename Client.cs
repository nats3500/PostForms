using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Post
{
    public partial class Client : Form
    {
        //Thread th;
        public Client()
        {
            InitializeComponent();
        }
        // переход на форму добавления почтоавых адресов
        private void AddAdresses_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAddress addAddress = new AddAddress();
            addAddress.Show();

        }
        // переход на форму просмотра почты
        private void ShowMail_Click(object sender, EventArgs e)
        {
            this.Hide();
            MailboxForm mailboxForm = new MailboxForm();
            mailboxForm.Show();
        }

        // отправка письма
        private void Send_Click(object sender, EventArgs e)
        {
            //создание письма
            Mail mail = new Mail(textBoxSender.Text, textBoxRecipient.Text,
                textBoxTitle.Text, textBoxContent.Text);

            if (!Mailboxes.mailboxIsExist(textBoxSender.Text))
                Mailboxes.AddMailbox(new Mailbox(textBoxSender.Text));
            //отправка письма
            MailSystem.SendMail(mail);
            MessageBox.Show("Сообщение отправлено");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

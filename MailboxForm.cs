using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Post
{
    public partial class MailboxForm : Form
    {
        public MailboxForm()
        {
            InitializeComponent();

            //постараться переписать на линк
            foreach (var mailbox in Mailboxes.MailboxesArr)
            {
                menuAddresses.Items.Add(mailbox.Address);
            }

        }

        // добавление письем в контейнер listbox по выбраному адресу
        private void menuAddresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            //переписать на линк
            string mailboxAddress = (menuAddresses.SelectedItem as string);

            foreach (var mailbox in Mailboxes.MailboxesArr)
                if (mailboxAddress == mailbox.Address)
                {
                    foreach (var mail in mailbox.IncomingMail)
                        listMailbox.Items.Add(mail.ToString());
                    break;
                }
    
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // переход на форму добавления адресов
        private void AddAdress_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAddress addAddress = new AddAddress();
            addAddress.Show();
        }
        // переход на странцу отправки сообщения
        private void SendMessageButtonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client sendMessage = new Client();
            sendMessage.Show();
        }
    }
}

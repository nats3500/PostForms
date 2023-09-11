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
    public partial class AddAddress : Form
    {
        public AddAddress()
        {
            InitializeComponent();
        }
        //переход на отправку письма
        private void buttonSendMail_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client sendMailForm = new Client();
            sendMailForm.Show();
        }
        // переход на экран просмотра почты
        private void ShowMail_Click(object sender, EventArgs e)
        {
            this.Hide();
            MailboxForm mailboxForm = new MailboxForm();
            mailboxForm.Show();
        }
        // добавление почтовых адресов
        private void buttonAddAddress_Click(object sender, EventArgs e)
        {
            //переписать на линк 
            foreach (var str in textBoxAddress.Lines)
                if (!Mailboxes.mailboxIsExist(str))
                    Mailboxes.AddMailbox(new Mailbox(str));

            MessageBox.Show("Адреса сохранены");
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

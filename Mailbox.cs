using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    static class Mailboxes
    {
        private static  List<Mailbox> mailboxes = new List<Mailbox>();
        // проверка на существование адреса
        public static List<Mailbox> MailboxesArr
        { 
            get => mailboxes;
            private set => mailboxes = value;
        }
        public static bool mailboxIsExist(string address)
        {
            var addr = from box in mailboxes
                       where address == box.Address
                       select box.Address;
            if(addr.Count() > 0)
                return true;
 
            return false;
        }
        public static void AddMailbox(Mailbox mailbox)
        {
            Mailboxes.mailboxes.Add(mailbox);
        }
    }

    class Mailbox
    {
        public Mailbox(string address = "Пользователь") 
        {
            Address = address;
            incomingMail = new List<Mail>();
        }
        public string Address { get; private set; }
        // список полученых писем
        private List<Mail> incomingMail;
        public List<Mail> IncomingMail
        { get => incomingMail; private set => incomingMail = value; }
        //получение письма
        public void ReceiveMail(Mail mail)
        {
            mail.MarkAsDelivered();
            incomingMail.Add(mail);
        }
    }
}

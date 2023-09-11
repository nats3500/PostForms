using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    abstract class MailSystem
    {
        private static List<Mail> mailQueue = new List<Mail>();
        //отправка письма
        public static void SendMail(Mail mail)
        {
            mail.CurrentLocation = "В почтовой системе";
            mailQueue.Add(mail);
            ProcessMail();
        }
        //обработка письма
        private static void ProcessMail()
        {
            //переписать на линк
            foreach (Mail mail in mailQueue.ToList())
            {
                foreach (Mailbox mailbox in Mailboxes.MailboxesArr)
                {
                    if (mail.Recipient == mailbox.Address)
                    {
                        mail.CurrentLocation = "В доставке";
                        mailbox.ReceiveMail(mail);
                        mailQueue.Remove(mail);
                    }
                }
            }
        }
    }
}

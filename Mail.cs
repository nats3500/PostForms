using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    class Mail
    {
        public Mail(string sender, string recipient,
            string title, string content)
        {
            Sender = sender;
            Recipient = recipient;
            Title = title;
            Content = content;
            IsDelivered = false;
            CurrentLocation = "У отправителя";
        }
        public string Sender { get; private set; }
        public string Recipient { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string CurrentLocation { get; /*private*/ set; }

        private bool IsDelivered;
        // отметка о доставке
        public bool MarkAsDelivered()
        {
            IsDelivered = true;
            Console.WriteLine("Письмо доставлено");
            return true;
        }
        public override string  ToString()
        {
            return $" Отправитель: {Sender} \n" +
                $"Получатель: {Recipient} \n" +
                $"Название: {Title} \n" +
                $"Текст письма: {Content} \n";
        }

    }
}

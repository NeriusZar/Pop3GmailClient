using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopClient
{
    public class Message
    {
        private string message;
        private string subject;
        private string body;
        private string from;
        public string GetBody()
        {
            return body;
        }
        public string GetFrom()
        {
            return from;
        }
        public string GetSubject()
        {
            return subject;
        }
        public Message(string message)
        {
            this.message = message;
            SetBody(this.message);
            SetSubject(this.message);
            SetFrom(this.message);
        }
        private void SetBody(string message)
        {
            message = message.Remove(0, message.IndexOf("\r\n\r\n")+2);
            message = message.Remove(0, message.IndexOf("\r\n\r\n")+2);
            body = message.Remove(message.IndexOf("\r\n\r\n"), (message.Length - message.IndexOf("\r\n\r\n")));
        }
        private void SetSubject(string message)
        {
            message = message.Remove(0, (message.IndexOf("\r\nSubject:") + 10));
            subject = message.Remove(message.IndexOf('\r'), (message.Length - message.IndexOf('\r')));   
        }
        private void SetFrom(string message)
        {
            message = message.Remove(0, (message.IndexOf("\r\nFrom:") + 7));
            message = message.Remove(message.IndexOf('\r'), ((message.Length - message.IndexOf('\r')) - 1));
            message = message.Remove(0, message.IndexOf('<') + 1);
            from = message.Remove(message.IndexOf('>'), 1);
        }
    }
}

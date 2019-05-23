using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PopClient
{
    class Pop3Client
    {
        private const string host = "pop.gmail.com";
        private const int port = 995;
        private TcpClient tcpClient;
        private SslStream sslStream;
        private byte[] buffer;
    
        public Pop3Client()
        {
            buffer = new byte[8172];
        }
        public bool Connect()
        {
            tcpClient = new TcpClient();
            tcpClient.Connect(host, port);
            sslStream = new SslStream(tcpClient.GetStream());
            sslStream.AuthenticateAsClient(host);
            int bytes = sslStream.Read(buffer, 0, buffer.Length);
            return MessageEncoder.ServerResponseCheck(buffer, bytes);
        }
        public void Disconnect()
        {
            sslStream.Write(MessageEncoder.QuitCommand());
            sslStream.Close();
            tcpClient.Close();
        }
        public bool Login(string email, string password)
        {
            if (!tcpClient.Connected)
                return false;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                return false;
            int bytesRead = -1;
            //Send the users login details
            sslStream.Write(MessageEncoder.UserCommand(email));

            bytesRead = sslStream.Read(buffer, 0, buffer.Length);
            if (!MessageEncoder.ServerResponseCheck(buffer,bytesRead))
                return false;
            //Send the password                        
            sslStream.Write(MessageEncoder.PassCommand(password));

            bytesRead = sslStream.Read(buffer, 0, buffer.Length);
            if (!MessageEncoder.ServerResponseCheck(buffer,bytesRead))
                return false;
            return true;
        }
        public int GetMailCount()
        {
            //Send mail count request
            sslStream.Write(MessageEncoder.StatCommand());
            int bytesRead = sslStream.Read(buffer, 0, buffer.Length);
            string data = MessageEncoder.EncodeMessage(bytesRead, buffer);
            data = data.Remove(0, 4);
            string[] mailCountData = data.Split(' ');
            int mailCount;
            if (Int32.TryParse(mailCountData[0], out mailCount))
            {
                return mailCount;
            }
            return -1;
        }
        public Message GetMessage(int messageNumber)
        {
            string message = String.Empty;
            sslStream.Write(MessageEncoder.RetrCommand(messageNumber));
            int bytesRead = -1;
            while (bytesRead != 0 && !message.Contains("\r\n.\r\n"))
            {
                bytesRead = sslStream.Read(buffer, 0, buffer.Length);
                message += MessageEncoder.EncodeMessage(bytesRead, buffer);
            }
            return new Message(message);
        }
        public void Reset()
        {
            sslStream.Write(MessageEncoder.ResetCommand());
        }
        public bool DeleteMessage(int messageNumber)
        {
            int bytesRead = -1;
            sslStream.Write(MessageEncoder.DeleteCommand(messageNumber));
            bytesRead = sslStream.Read(buffer, 0, buffer.Length);
            if (!MessageEncoder.ServerResponseCheck(buffer, bytesRead))
                return false;
            else return true;

        }
    }
}

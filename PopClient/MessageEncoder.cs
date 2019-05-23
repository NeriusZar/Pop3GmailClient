using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopClient
{
    enum Commands
    {
        RETR,
        TOP,
        RSET,
        STAT,
        PASS,
        USER,
        QUIT,
        DELE
    }
    public class MessageEncoder
    {
        private const string space = " ";

        public static bool ServerResponseCheck(byte[] buffer, int bytes)
        {
            return Encoding.ASCII.GetString(buffer, 0, bytes).Contains("+OK");
        }
        public static byte[] QuitCommand()
        {
            return Encoding.ASCII.GetBytes(Commands.QUIT + Environment.NewLine);
        }
        public static byte[] UserCommand(string username)
        {
            return Encoding.ASCII.GetBytes(Commands.USER + space + username + Environment.NewLine);
        }
        public static byte[] PassCommand(string password)
        {
            return Encoding.ASCII.GetBytes(Commands.PASS + space + password + Environment.NewLine);
        }
        public static byte[] StatCommand()
        {
            return Encoding.ASCII.GetBytes(Commands.STAT + Environment.NewLine);
        }
        public static string EncodeMessage(int bytes, byte[] buffer)
        {
            return Encoding.ASCII.GetString(buffer, 0, bytes);
        }
        public static byte[] RetrCommand(int messageNumber)
        {
            return Encoding.ASCII.GetBytes(Commands.RETR + space + messageNumber.ToString() + Environment.NewLine);
        }
        public static byte[] DeleteCommand(int messageNumber)
        {
            return Encoding.ASCII.GetBytes(Commands.DELE + space + messageNumber.ToString() + Environment.NewLine);
        } 
        public static byte[] ResetCommand()
        {
            return Encoding.ASCII.GetBytes(Commands.RSET + Environment.NewLine);
        }
    }
}

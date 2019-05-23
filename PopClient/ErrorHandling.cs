using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopClient
{
    public class ErrorHandling
    {
        public static void ConnectionError()
        {
            MessageBox.Show("Connection error");
        }
        public static void LoginError()
        {
            MessageBox.Show("Wrong username or password");
        }
        public static void NotConnectedError()
        {
            MessageBox.Show("You are not connected");
        }
    }
}

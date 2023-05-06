using System;

namespace Notification
{
    public class Receiver
    {
        public void BlockAccount()
        {
            Console.WriteLine(" Your Account Has Been Block Temporary ...");
        }

        public void SendEmail()
        {
            Console.WriteLine(" Mail Has Been Send to Register Email Address");
        }

        public void SendSMS()
        {
            Console.WriteLine(" Sms Has Been Send to Register Mobile Number");
        }
    }
}
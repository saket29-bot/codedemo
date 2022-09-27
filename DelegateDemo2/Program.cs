using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            acc1.alert += Notification.SendEmail;
            acc1.alert +=Notification.SendSMS;
            Console.WriteLine($"Initial balance : {acc1.Balance}");
            acc1.Deposite(5000);
            Console.WriteLine($"After Deposite : {acc1.Balance}");
            acc1.Withdraw(1000);
            Console.WriteLine($"After Withdraw balance : {acc1.Balance}");

        }
    }
    //Declare the Deligate
    public delegate void Alert(string msg);
    class Account
    {
        public int Balance{ get; private set; }//making read-Only 
        public event Alert alert = null;//Restricted version of Delegates;
        public void Deposite(int amount)
        {
            Balance += amount;
            //Notification.SendEmail($"Credited:{amount}");
            if (alert != null)
                alert($"Credited:{amount}");
        }
        public void Withdraw(int amount)
        {
            Balance-= amount;
            //Notification.SendEmail($"Debited:{amount}");
            if (alert != null)
                alert($"Credited:{amount}");
        }
    }
    public class Notification
    {
        public static void SendEmail(string msg)
        {
            //Smtp cLient
            //MailMessage
            Console.WriteLine($"Mail:{msg}");
        }
        public static void SendSMS(string msg)
        {
            //Smtp cLient
            //MailMessage
            Console.WriteLine($"SMS:{msg}");
        }
    }
}

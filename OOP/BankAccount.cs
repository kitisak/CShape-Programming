using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class BankAccount
    //public class BankAccount
    {
        // Encapsulation : Information Hiding
        // Field : ตัวแปรในคลาส
        private string strAccountName;
        protected decimal decBalance;

        // Constructor
        // Overload คือ การที่เมธอดมีชื่อเหมือนกัน แต่มี parameter/signature ต่างกัน
        public BankAccount() 
        {
            strAccountName = "[Unknow]";
            decBalance = 0;
        }

        public BankAccount(string name)
        {
            strAccountName = name;
            decBalance = 0;
        }

        public BankAccount(string name, decimal balance)
        {
            strAccountName = name;
            decBalance = balance;
        }

        // Property
        public string AccountName
        {
            get { return strAccountName; }
            set { strAccountName = value; }
        }

        public decimal Balance
        {
            // Read-Only Property
            get { return decBalance; }
        }

        // Method : ความสามารถของของคลาส
        public void Deposit(decimal amount) {
            decBalance += amount;        
        }

        public void Withdraw(decimal amount)
        {
            decBalance -= amount;
        }

        public abstract decimal CallInterest();        

    }
}

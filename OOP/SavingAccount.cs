using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class SavingAccount : BankAccount
    {
        /*
        // Override --> Polymorphism
        public sealed override decimal CallInterest()
        {
            return decBalance * 0.3m;
        }
        */
        public override decimal CallInterest()
        {
            throw new NotImplementedException();
        }
    }

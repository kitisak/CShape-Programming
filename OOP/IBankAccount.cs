using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IBankAccount
    {
        //Property
        string Name();
        decimal Balance();

        //Method
        void Deposit();
        void Withdraw();
        decimal CallInterest();
    }
}

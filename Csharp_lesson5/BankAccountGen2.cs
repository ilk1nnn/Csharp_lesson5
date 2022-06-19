




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_lesson5
{
    public partial class BankAccount
    {

        public BankAccount(string name)
        {
            Console.WriteLine($" name --> {name}");
            ShowAccount();
            UpdateAccount();
        }

    }
}

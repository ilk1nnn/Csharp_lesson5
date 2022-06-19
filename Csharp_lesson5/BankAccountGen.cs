using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_lesson5
{
    public partial  class BankAccount
    {


        public BankAccount()
        {
            Console.WriteLine(" default constructor");
            ShowAccount();
            UpdateAccount();
        }

        partial void ShowAccount()
        {
            Console.WriteLine(" kapital bank hesab 1000 AZN");
        }
        partial void UpdateAccount()
        {
            Console.WriteLine(" update");
        }


    }
}

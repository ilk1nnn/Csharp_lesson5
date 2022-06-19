




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_lesson5
{
    public partial class BankAccount
    {

        public int Id { get; set; }
        public string Name { get; set; }

        partial void ShowAccount();
        partial void UpdateAccount();

    }
}

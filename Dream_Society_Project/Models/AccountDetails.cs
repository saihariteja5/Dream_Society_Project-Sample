using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream_Society_Project.Models
{
    public class AccountDetails
    {
        public int ID { get; set; }
        public int AccountNumber { get; set; }
        public DateTime DateOfOpen { get; set; }
        public int LoanAccount { get; set; }
        public DateTime DateOfLoan { get; set; }
        public int Amount { get; set; }
        public int EMI { get; set; }
        public int RemainingEMI { get; set; }
        public int AadharNumber { get; set; }
    }
}

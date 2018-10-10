using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream_Society_Project.Models
{
    public class Member
    {
        public int ID { get; set; }
        public string Member_Name { get; set; }
        public string Occupation { get; set; }
        public string Address { get; set; }
        public int ContactNumber { get; set; }
        public int AadharNumber { get; set; }
        public int LeadID { get; set; }

    }
}

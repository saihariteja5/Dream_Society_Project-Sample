using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamSociety.Models
{
    public class Lead
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Village { get; set; }
        public string Mandal { get; set; }
        public string BrnachName { get; set; }
        public int AadhaarNumber{ get; set; }
    }
}

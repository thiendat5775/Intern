using System;
using System.Collections.Generic;

#nullable disable

namespace Intern.Models
{
    public partial class Customer
    {
        public string Redemtioncode { get; set; }
        public int PhoneNo { get; set; }
        public DateTime DayOfRedemption { get; set; }
        public string Gift { get; set; }
        public string Status { get; set; }
        public string Store { get; set; }
    }
}

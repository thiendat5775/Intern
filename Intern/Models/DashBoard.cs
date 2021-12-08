using System;
using System.Collections.Generic;

#nullable disable

namespace Intern.Models
{
    public partial class DashBoard
    {
        public int Id { get; set; }
        public int PhoneNumber { get; set; }
        public string RedeemForProduct { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public string Store { get; set; }
        public string Status { get; set; }
    }
}

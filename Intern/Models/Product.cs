using System;
using System.Collections.Generic;

#nullable disable

namespace Intern.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Sku { get; set; }
        public string Inventory { get; set; }
        public DateTime ImportDate { get; set; }

        public virtual PromotionCollection InventoryNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Intern.Models
{
    public partial class PromotionCollection
    {
        public PromotionCollection()
        {
            Products = new HashSet<Product>();
        }

        public string CollectionName { get; set; }
        public string Campaign { get; set; }
        public string TotalOfProduct { get; set; }
        public string Inventory { get; set; }

        public virtual PromotionAll CampaignNavigation { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}

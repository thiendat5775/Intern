using System;
using System.Collections.Generic;

#nullable disable

namespace Intern.Models
{
    public partial class PromotionAll
    {
        public PromotionAll()
        {
            PromotionCollections = new HashSet<PromotionCollection>();
        }

        public string Campaign { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }

        public virtual ICollection<PromotionCollection> PromotionCollections { get; set; }
    }
}

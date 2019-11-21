using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheLeftOversClubTestApi.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string AdvancedDescription { get; set; }

        public string Picture { get; set; }
    }
}

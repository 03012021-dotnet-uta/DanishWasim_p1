using System;
using System.Collections.Generic;

#nullable disable

namespace models
{
    public partial class Store
    {

        public Store()
        {
            // LocationId = location_id;
            // LocationName = location_name;
        }

        public int LocationId { get; set; }
        public string LocationName { get; set; }
        
        
    }
}
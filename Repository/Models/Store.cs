using System;
using System.Collections.Generic;



namespace Repository.Models
{
    public partial class Store
    {
        public Store()
        {
            // Accounts = new HashSet<Account>();
            // Inventories = new HashSet<Inventory>();
            // Orders = new HashSet<Order>();
        }

        public int LocationId { get; set; }
        public string LocationName { get; set; }

        
    }
}
using System;
using System.Collections.Generic;

namespace models
{
    public partial class Inventory
    {
        // public object InventoryId;

        public int InventoryId { get; set; }
        public int StoreId { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }

        // public virtual Part PartNumberNavigation { get; set; }
        // public virtual Store StoreNumberNavigation { get; set; }
    }
}
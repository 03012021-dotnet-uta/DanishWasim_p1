using System;
using System.Collections.Generic;
using System.Linq;
using models;

namespace Repository
{
    public class StoreRepoLayer
    {
        private readonly memeSaverContext _dbContext;
        public StoreRepoLayer(memeSaverContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public List<Store> GetStores()
        {
            return _dbContext.Stores.ToList();
        }
        
    }
}
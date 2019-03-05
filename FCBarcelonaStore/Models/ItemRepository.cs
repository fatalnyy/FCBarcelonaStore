using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FCBarcelonaStore.Models
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _appDbContext;

        public ItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Item> GetAllItems()
        {
            return _appDbContext.Items.Include(c => c.Category);
        }

        public Item GetItem(int itemId)
        {
            return _appDbContext.Items.FirstOrDefault(p => p.Id == itemId);
        }
    }
}

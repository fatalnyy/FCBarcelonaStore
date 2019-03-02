using FCBarcelonaStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FCBarcelonaStore.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Item> Items { get; set; }
    }
}

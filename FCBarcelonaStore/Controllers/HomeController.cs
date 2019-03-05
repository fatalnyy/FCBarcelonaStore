using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FCBarcelonaStore.Models;
using FCBarcelonaStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FCBarcelonaStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;

        public HomeController(IItemRepository itemRepository, ICategoryRepository categoryRepository)
        {
            _itemRepository = itemRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to FC Barcelona Store",
                Items = _itemRepository.GetAllItems().OrderBy(p => p.Id).ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult List(string category)
        {
            IEnumerable<Item> items;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                items = _itemRepository.GetAllItems().OrderBy(i => i.Id);
                currentCategory = "Equipment";
            }
            else
            {
                items = _itemRepository.GetAllItems().Where(i => i.Category.CategoryName == category)
                    .OrderBy(i => i.Id);
                currentCategory = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }

            return View(new ItemsListViewModel
            {
                Items = items,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var item = _itemRepository.GetItem(id);
            if (item == null)
                return NotFound();

            return View(item);
        }
    }
}
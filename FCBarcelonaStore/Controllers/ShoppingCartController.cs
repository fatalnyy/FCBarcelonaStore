using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FCBarcelonaStore.Models;
using FCBarcelonaStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FCBarcelonaStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IItemRepository itemRepository, ShoppingCart shoppingCart)
        {
            _itemRepository = itemRepository;
            _shoppingCart = shoppingCart;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public IActionResult AddToShoppingCart(int itemId)
        {
            var selectedItem = _itemRepository.GetAllItems().FirstOrDefault(p => p.Id == itemId);

            if (selectedItem != null)
                _shoppingCart.AddToCart(selectedItem, 1);

            return View();
        }
    }
}

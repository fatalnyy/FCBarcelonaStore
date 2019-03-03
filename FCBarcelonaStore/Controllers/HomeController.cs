﻿using System;
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

        public HomeController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
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

        public IActionResult Details(int id)
        {
            var item = _itemRepository.GetItem(id);
            if (item == null)
                return NotFound();

            return View(item);
        }
    }
}
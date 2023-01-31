﻿using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Data;
using OnlineBookStore.Models;

namespace OnlineBookStore.Controllers
{
    public class CartController : Controller
    {
        private readonly Cart _cart;
        public CartController(Cart cart)
        {
            _cart = cart;
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}

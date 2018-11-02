﻿using Shop.ViewModel;
using System.Collections.Generic;

namespace Shop.Models
{
    public class ShoppingCart
    {
        public List<ShoppingCartItemViewModel> ShoppingCartItems { get; set; }
        public double PriceWithoutDiscount { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }

        public ShoppingCart() => ShoppingCartItems = new List<ShoppingCartItemViewModel>();
    }
}
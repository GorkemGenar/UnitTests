using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    //Gereksinimler
    //1. Sepete ürün eklenebilmelidir.
    //2. Sepette olan ürün çıkarılabilmelidir.
    //3. Sepet temizlenebilmelidir.

    //4. Sepete aynı ürün ikinci kez
    //   eklendiğinde hata vermelidir.

    //5. Sepete farklı üründen bir adet eklendiğinde sepetteki
    //   toplam ürün adedi ve eleman sayısı bir artmalı
    public class CartManager
    {
        private readonly List<CartItem> _cartItems;

        public CartManager()
        {
            _cartItems = new List<CartItem>();
        }

        public void Add(CartItem cartItem)
        {
            var addedCartItem = _cartItems.SingleOrDefault(
                p => p.Product.ProductId == cartItem.Product.ProductId);

            if (addedCartItem == null)
            {
                _cartItems.Add(cartItem);
            }
            else
            {
                throw new ArgumentException("This product has already been added.");
            }

            /*var addedCartItem = _cartItems.SingleOrDefault(p => p.Product.ProductId == cartItem.Product.ProductId);

            if (addedCartItem == null)
            {
                _cartItems.Add(cartItem);
            }
            else
            {
                addedCartItem.Quantity += cartItem.Quantity;
            }*/
        }

        public void Remove(int productId)
        {
            var product = _cartItems.FirstOrDefault(p => p.Product.ProductId == productId);
            _cartItems.Remove(product);
        }

        public List<CartItem> CartItems
        {
            get
            {
                return _cartItems;
            }
        }

        public void Clear()
        {
            _cartItems.Clear();
        }

        public decimal TotalPrice
        {
            get
            {
                return _cartItems.Sum(p => p.Quantity * p.Product.UnitPrice);
            }
        }

        public decimal TotalQuantity
        {
            get
            {
                return _cartItems.Sum(p => p.Quantity);
            }
        }

        public decimal TotalItems
        {
            get
            {
                return _cartItems.Count;
            }
        }
    }
}

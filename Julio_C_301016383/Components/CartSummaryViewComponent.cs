using Microsoft.AspNetCore.Mvc;
using Julio_C_301016383.Models;

namespace Julio_C_301016383.Components
{

    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
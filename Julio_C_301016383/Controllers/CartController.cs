using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Julio_C_301016383.Models;
using Julio_C_301016383.Infrastructure;

namespace Julio_C_301016383.Controllers
{
    public class CartController : Controller
    {
        private IMatchRepository repository;
        private Cart cart;

        public CartController(IMatchRepository repo, Cart cartService)
        {
            repository = repo;
            cart = cartService;
        }

        public ViewResult Index(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(cart);
        }

        public RedirectToActionResult AddToCart(int matchID, string returnUrl)
        {
            Match match = repository.GetListOfMatches().FirstOrDefault(m => m.MatchID == matchID);

            if (match != null)
            {                
                cart.AddItem(match, 1);                
                //TempData["message"] = "Carrinho adicionado.";
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int matchID, string returnUrl)
        {
            Match match = repository.GetListOfMatches().FirstOrDefault(m => m.MatchID == matchID);

            if (match != null)
            {
                cart.RemoveLine(match);             
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        //private Cart GetCart()
        //{
        //    Cart cart = HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();
        //    return cart;
        //}

        //private void SaveCart(Cart cart)
        //{
        //    HttpContext.Session.SetJson("Cart", cart);
        //}
    }
}
using Microsoft.AspNetCore.Mvc;
using SEEDCAFE.Models;
using System.Linq;
namespace SEEDCAFE.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private MyCart cart;
        public OrderController(IOrderRepository repoService, MyCart cartService)
        {
            repository = repoService;
            cart = cartService;
        }
        public ViewResult Checkout() => View(new Order());
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Xin lỗi, giỏ của bạn hiện đang trống ");
            }
            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                repository.SaveOrder(order);
                cart.Clear();
                return RedirectToPage("/Xong ", new { orderId = order.OrderID });
            }
            else
            {
                return View();
            }
        }
    }
}

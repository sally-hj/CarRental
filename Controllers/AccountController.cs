using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            // Simuler un utilisateur connecté
            ViewBag.TotalLocations = 2;
            ViewBag.UserName = "Yassine";
            ViewBag.UserEmail = "yassine.client@email.com";
            ViewBag.MemberSince = "2025";

            return View();
        }

        public IActionResult Logout()
        {
            // Rediriger vers l'accueil
            return RedirectToAction("Index", "Home");
        }
    }
}
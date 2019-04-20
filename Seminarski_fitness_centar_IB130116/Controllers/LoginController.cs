using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Seminarski_fitness_centar_IB130116.DB;
using Seminarski_fitness_centar_IB130116.Helper;
using Seminarski_fitness_centar_IB130116.Models;
using Seminarski_fitness_centar_IB130116.ViewModels;

namespace Seminarski_fitness_centar_IB130116.Controllers
{
    public class LoginController : Controller
    {
        
        public IActionResult Index(LoginVM input)
        {
            if (input.IsLogging == 1)
            {
                if (ModelState.IsValid)
                {
                    MyContext _db = new MyContext();
                    User korisnik = _db.Users.Where(x => x.Username == input.Username && x.Password == input.Password)
                        .SingleOrDefault();

                    if (korisnik != null)
                    {
                        HttpContext.Session.Set("LoggedInUser", korisnik);
                        TempData["TekSeLogirao"] = true;
                        return RedirectToAction("Index", "Index");
                    }

                    ViewData["ErrorMessage"] = "Pogrešan username ili lozinka";
                    return View("Login", input);

                }
                else
                {
                    return View("Login", input);
                }
            }
            else
            {
                ModelState.Clear();
                return View("Login", input);
            }
        }

        public IActionResult Logout()
        {
            GetSetUser.SetLoggedUser(HttpContext, null, false);
            TempData["ErrorMessage"] = "Uspjesan logout";
            return RedirectToAction("Index", "Login", null);
        }

    }
}
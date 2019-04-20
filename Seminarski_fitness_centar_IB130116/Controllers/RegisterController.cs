using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Seminarski_fitness_centar_IB130116.DB;
using Seminarski_fitness_centar_IB130116.Helper;
using Seminarski_fitness_centar_IB130116.Models;
using Seminarski_fitness_centar_IB130116.ViewModels;

namespace Seminarski_fitness_centar_IB130116.Controllers
{
    public class RegisterController : Controller
    {
        MyContext db = new MyContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register(RegisterVM input)
        {
                    
            if (ModelState.IsValid)
            {
                if (CheckEmail(input.Email)) //dodatna back-end provjera za zauzetost maila jer ModelState.IsValid ne provjerava REMOTE
                {
                    ModelState.AddModelError("Email", $"Email {input.Email} je zauzet!");
                    //TempData["ErrorMessage"] = "Check the fields";
                }
                if (CheckEmail(input.Username)) //dodatna back-end provjera za zauzetost username jer ModelState.IsValid ne provjerava REMOTE
                {
                    ModelState.AddModelError("Username", $"Username {input.Username} je zauzet!");
                    //TempData["ErrorMessage"] = "Check the fields";
                }

                if(CheckEmail(input.Username) || CheckEmail(input.Email)) return PartialView("Register", input);
                TempData["ErrorMessage"] = "Uspjesna registracija!"; //obavijesti korisnika o uspjesnoj registraciji
                //dodaj korisnika u bazu

                User novi = new User
                {
                    Username = input.Username,
                    Password = input.Password,
                    Email = input.Email,
                    Role = 0
                };
                db.Users.Add(novi);
                db.SaveChanges();

                Zaposlenik novi_zaposlenik = new Zaposlenik
                {
                    User = novi,
                    UserId = novi.UserId
                };
                db.Zaposlenici.Add(novi_zaposlenik);
                db.SaveChanges();
                GetSetUser.SetLoggedUser(HttpContext, novi, false); //automatski logiraj novoregistrovanog korisnika
                //dodaj zaposlenika u tabelu zaposlenici, default korisnik je zaposlenik
                return RedirectToAction("Index", "Index");

            }
            else
            {
                //TempData["ErrorMessage"] = "Check the fields";
                return PartialView("Register", input);
            }

        }

        public bool CheckEmail(string email)
        {
            if (db.Users.Any(u => u.Email == email))
            {
                return true;
            }
            return false;
        }

        public bool CheckUsername(string username)
        {
            if (db.Users.Any(u => u.Username == username))
            {
                return true;
            }
            return false;
        }

        public IActionResult CheckEmailAvailability(string email)
        {
            if (db.Users.Any(u => u.Email == email))
            {
                return Json($"Email {email} je zauzet!");
            }
            return Json(true);
        }

        public IActionResult CheckUsernameAvailability(string username)
        {
            if (db.Users.Any(u => u.Username == username))
            {
                return Json($"Username {username} je zauzet!");
            }
            return Json(true);
        }

    }
      
    
}
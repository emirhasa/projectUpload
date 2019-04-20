using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using Seminarski_fitness_centar_IB130116.DB;
using Seminarski_fitness_centar_IB130116.Helper;
using Seminarski_fitness_centar_IB130116.Models;
using Seminarski_fitness_centar_IB130116.ViewModels;

namespace Seminarski_fitness_centar_IB130116.Controllers
{
    public class DolasciOdlasciController : Controller
    {
        MyContext db = new MyContext();
        public IActionResult Zaposlenici()
        {
            List<User> model = db.Users.Where(U=>U.Role == 0).ToList();
            return View(model);
        }

        public IActionResult SnimiDolazak()
        {
            User user = HttpContext.GetLoggedUser();

            DolazakOdlazak dolazak = new DolazakOdlazak
            {
                UserId = user.UserId,
                VrijemeDolaska = DateTime.Now
            };
            db.DolasciOdlasci.Add(dolazak);
            db.SaveChanges();
            TempData["ErrorMessage"] = "Dolazak prijavljen!!!";
            return RedirectToAction("ZaposlenikDolasciDetalji", "DolasciOdlasci");
        }

        public IActionResult SnimiOdlazak(int DolazakOdlazakId)
        {
            User user = HttpContext.GetLoggedUser();
            if (DolazakOdlazakId != 0)
            {
                DolazakOdlazak odlazak =
                    db.DolasciOdlasci.Where(DO => DO.DolazakOdlazakId == DolazakOdlazakId && DO.UserId == user.UserId).Single();
                if (odlazak != null)
                {
                    DolazakOdlazak novi = new DolazakOdlazak
                    {
                        DolazakOdlazakId = odlazak.DolazakOdlazakId,
                        User = user,
                        UserId = user.UserId,
                        VrijemeDolaska = odlazak.VrijemeDolaska,
                        VrijemeOdlaska = DateTime.Now
                    };
                    db.Entry(odlazak).CurrentValues.SetValues(novi);
                    db.SaveChanges();
                    TempData["ErrorMessage"] = "Odlazak prijavljen!!!";
                    return RedirectToAction("ZaposlenikDolasciDetalji", "DolasciOdlasci");
                }
            }

            TempData["ErrorMessage"] = "Error";
            return RedirectToAction("Index", "Index");
            
        }

        public IActionResult ZaposlenikDolasciDetalji()
        {
            User user = HttpContext.GetLoggedUser();

            DolasciOdlasciVM model = new DolasciOdlasciVM
            {
                Rows = db.DolasciOdlasci.Where(DO => DO.UserId == user.UserId).Select(DO => new DolasciOdlasciVM.Row
                {
                    DolazakOdlazakId = DO.DolazakOdlazakId,
                    VrijemeDolaska = DO.VrijemeDolaska,
                    VrijemeOdlaska = DO.VrijemeOdlaska,
                    User = DO.User,
                    UserId = DO.UserId
                }).ToList()
            };
            return View(model);
        }

        public IActionResult AdminDolasciDetalji(int ZaposlenikId)
        {
            User user = HttpContext.GetLoggedUser();
            if (user.Role == 0)
            {
                TempData["ErrorMessage"] = "Nemate pravo pristupa!";
                return RedirectToAction("Index", "Index");
            }
            DolasciOdlasciVM model = new DolasciOdlasciVM
            {
                Rows = db.DolasciOdlasci.Where(DO => DO.UserId == ZaposlenikId).Select(DO => new DolasciOdlasciVM.Row
                {
                    DolazakOdlazakId = DO.DolazakOdlazakId,
                    VrijemeDolaska = DO.VrijemeDolaska,
                    VrijemeOdlaska = DO.VrijemeOdlaska,
                    User = DO.User,
                    UserId = DO.UserId
                }).ToList()
            };
            return View(model);
        }
    }
      
    
}
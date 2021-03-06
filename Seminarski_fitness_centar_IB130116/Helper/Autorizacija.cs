﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Seminarski_fitness_centar_IB130116.DB;
using Seminarski_fitness_centar_IB130116.Helper;
using Seminarski_fitness_centar_IB130116.Models;

namespace eUniverzitet.Web.Helper
{

    public class AutorizacijaAttribute : TypeFilterAttribute
    {
        public AutorizacijaAttribute(bool guest, bool zaposlenik, bool admin, bool master)
            : base(typeof(MyAuthorizeImpl))
        {
            Arguments = new object[] { guest, zaposlenik, admin, master };
        }
    }


    public class MyAuthorizeImpl : IAsyncActionFilter
    {
        public MyAuthorizeImpl(bool guest, bool zaposlenik, bool admin, bool master)
        {
            _guest = guest;
            _zaposlenik = zaposlenik;
            _admin = admin;
            _master = master;
        }
        private readonly bool _guest;
        private readonly bool _zaposlenik;
        private readonly bool _admin;
        private readonly bool _master;
        public async Task OnActionExecutionAsync(ActionExecutingContext filterContext, ActionExecutionDelegate next)
        {
            User k = filterContext.HttpContext.GetLoggedUser();

            if (k == null)
            {
                if (filterContext.Controller is Controller controller)
                {
                    controller.TempData["ErrorMessage"] = "Niste logirani";
                    
                }
                filterContext.Result = new RedirectToActionResult("Index", "Login", new { @area = "" });
                return;
            }

            //Preuzimamo DbContext preko app services
            MyContext db = new MyContext();

            //guest moze pristupiti
            if (_guest)
            {
                await next(); //ok - ima pravo pristupa
                return;
            }

            //zaposlenik moze pristupiti
            if (_zaposlenik && db.Zaposlenici.Any(s => s.UserId == k.UserId))
            {
                await next(); //ok - ima pravo pristupa
                return;
            }

            //admin moze pristupiti
            if (_admin && db.Admini.Any(s => s.UserId == k.UserId))
            {
                await next();//ok - ima pravo pristupa
                return;
            }

            //master moze pristupiti
            if (_master && db.Admini.Any(s => s.UserId == k.UserId && s.MasterAdmin == true ))
            {
                await next();//ok - ima pravo pristupa
                return;
            }

            if (filterContext.Controller is Controller c1)
            {
                c1.TempData["ErrorMessage"] = "Nemate pravo pristupa";
            }

            filterContext.Result = new RedirectToActionResult("Index", "Index", new { @area = "" });
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // throw new NotImplementedException();
        }
    }
}


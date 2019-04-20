using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Seminarski_fitness_centar_IB130116.Models;

namespace Seminarski_fitness_centar_IB130116.Helper
{
    public static class GetSetUser
    {
        private const string LogiraniKorisnik = "LoggedInUser";

        public static void SetLoggedUser(this HttpContext Context, User user, bool SnimiUCookie = false)
        {
            Context.Session.Set(LogiraniKorisnik, user);
        }

        public static User GetLoggedUser(this HttpContext Context)
        {
            User user = Context.Session.Get<User>(LogiraniKorisnik);

            return user;
        }

    }
}

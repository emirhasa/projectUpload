using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Seminarski_fitness_centar_IB130116.Models
{
    public class User
    {
        [Key] public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Role{ get; set; } //0 - zaposlenik(obicni) user, 1-admin, 2-master admin
    }
}

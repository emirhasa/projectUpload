﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Seminarski_fitness_centar_IB130116.Models
{
    public class Zaposlenik
    {

        [Key]
        public int ZaposlenikId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
           
    }
}

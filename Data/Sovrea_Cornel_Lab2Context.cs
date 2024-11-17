﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sovrea_Cornel_Lab2.Models;

namespace Sovrea_Cornel_Lab2.Data
{
    public class Sovrea_Cornel_Lab2Context : DbContext
    {
        public Sovrea_Cornel_Lab2Context (DbContextOptions<Sovrea_Cornel_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Sovrea_Cornel_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Sovrea_Cornel_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}

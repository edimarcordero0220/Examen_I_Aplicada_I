﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class RegistroClienteDb:DbContext
    {
        public RegistroClienteDb() :base ("name=ConStr")
        {
           
        }
        public virtual DbSet<Usuarios> Usuario { get; set; }
    }
}

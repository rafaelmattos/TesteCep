using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TesteCep2.Models
{
    public class Contexto : DbContext
    {
        

        public Contexto() : base("Contexto")
        {

        }

        public DbSet<Cep> Cep { get; set; }
    }
}
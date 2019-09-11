using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalProject2._0.Models
{
    public class ContextDb : DbContext
    {
        public DbSet<Cliente> clientes { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalProjectWEBAPI.Models
{
    public class ContextDb : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoVeiculo> Veiculos { get; set; }
        public DbSet<TermoDeUso> TermoDeUsos { get; set; }
        public DbSet<Periodo> Periodos { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Locacao> Locacaos { get; set; }
        public DbSet<Cor> Cors { get; set; }
        public DbSet<Administrador> Administradors { get; set; }

    }
}
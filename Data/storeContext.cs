using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using store.Models;

namespace store.Data
{
    public class storeContext : DbContext
    {
        public storeContext (DbContextOptions<storeContext> options)
            : base(options)
        {
        }
        
        public DbSet<Produit> Produit { get; set; }
        public DbSet<Famille> Famille { get; set; }
        public DbSet<store.Models.Type> Type { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Commande> Commande { get; set; }
        public DbSet<DétailsCommande> DétailsCommande { get; set; }
        public DbSet<Societe> Societe { get; set; }



    }
}

using System;
using Microsoft.EntityFrameworkCore;
using FruityEd.MobileAppService.Core.Models;
using Microsoft.EntityFrameworkCore.Design;

namespace FruityEd.MobileAppService.Persistence
{
    public class FruityEdDbContext: DbContext
    {

        public DbSet<Location> Locations { get; set; }


        public FruityEdDbContext(DbContextOptions<FruityEdDbContext> options)
            : base(options) 
        {
           


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

       

       



        }




        


    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using testTrain.Model;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using testTrain.Model.ViewModels;

namespace testTrain.Data
{
    public class DataContext : IdentityDbContext<DelieveryMan>
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<testTrain.Model.ViewModels.CreateDeliveryManVM> CreateDeliveryManVM { get; set; }

       

   
    }
}

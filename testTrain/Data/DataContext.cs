using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using testTrain.Model;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using testTrain.Model.DOTs.Requests;

namespace testTrain.Data
{
    public class DataContext : IdentityDbContext<LoginUser>
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<delieveryMan> delieveryDrivers { get; set; }
    }
}

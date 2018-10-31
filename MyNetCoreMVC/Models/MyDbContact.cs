using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyNetCoreMVC.Models
{
    public class MyDbContact : DbContext
    {
        public MyDbContact(DbContextOptions<MyDbContact> options)
            : base(options)
        {
        }

        public DbSet<MyDbContact> Products { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

        internal object Update()
        {
            throw new NotImplementedException();
        }
    }
}

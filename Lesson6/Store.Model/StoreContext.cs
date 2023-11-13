using Microsoft.EntityFrameworkCore;
using Store.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class StoreContext:DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> option):base(option)
        {

        }
        public DbSet<Item> Items { get; set; }
    }
}

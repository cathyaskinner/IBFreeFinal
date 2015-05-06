using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using IBFree.Models;

namespace IBFree.Models
{
    public class IBFreeContext  :   DbContext
    {
        public DbSet<BadFood> BadFoods { get; set;}
        public DbSet<BigViewModel> BigViewDb { get; set; }
 

    }
}
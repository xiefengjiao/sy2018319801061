using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace sy201831980106.Models
{
    public class MyDb:DbContext
    {
        public MyDb():base("name=DefaultConnection")
        {

        }
        public DbSet<sy201831980106.Models.Xueshengxinxi> Xueshengxinxis { get; set; }

        public DbSet<sy201831980106.Models.Chengji> Chengjis { get; set; }

    }
}
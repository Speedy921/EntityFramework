using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Entity
{
    public class MyDbContext: DbContext
    {
        public MyDbContext() : base("DBConnetionString")
        {
            
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Song> Songs { get; set; }
     }
}

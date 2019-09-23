using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDB
{
    internal class BlogContext : DbContext
    {
        public BlogContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public IDbSet<Article> Articles { get; set; }
        public IDbSet<Review> Reviewes { get; set; }
    }
}
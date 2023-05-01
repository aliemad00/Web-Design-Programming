using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using industry4._0.Models;
using industry4._0.Controllers;

namespace industry4._0.Data
{
    public class industry4_0Context : DbContext
    {
        public industry4_0Context (DbContextOptions<industry4_0Context> options)
            : base(options)
        {
        }
        public DbSet<industry4._0.Models.FeedbackPost> FeedbackPost { get; set; }

    }
}

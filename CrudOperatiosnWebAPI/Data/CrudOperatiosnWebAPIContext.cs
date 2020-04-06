using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrudOperatiosnWebAPI.Models
{
    public class CrudOperatiosnWebAPIContext : DbContext
    {
        public CrudOperatiosnWebAPIContext (DbContextOptions<CrudOperatiosnWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<CrudOperatiosnWebAPI.Models.User> User { get; set; }
    }
}

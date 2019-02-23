using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MISContext: DbContext
    {
        public MISContext(): base("DefaultConnection")
        {

        }
        public virtual DbSet<Goal>Goals { get; set; }
    }
}

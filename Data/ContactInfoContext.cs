using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContactInfo.Models;

namespace ContactInfo.Data
{
    public class ContactInfoContext : DbContext
    {
        public ContactInfoContext (DbContextOptions<ContactInfoContext> options)
            : base(options)
        {
        }

        public DbSet<ContactInfo.Models.Contact>? Contact { get; set; }
    }
}

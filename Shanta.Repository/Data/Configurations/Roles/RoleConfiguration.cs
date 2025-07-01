using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Repository.Data.Configurations.Roles
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole { Name = "admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "customer", NormalizedName = "CUSTOMER" },
                new IdentityRole { Name = "delivery", NormalizedName = "DELIVERY" },
                new IdentityRole { Name = "warehousemanager", NormalizedName = "WAREHOUSEMANAGER" },
                new IdentityRole { Name = "hr", NormalizedName = "HR" },
                new IdentityRole { Name = "supplier", NormalizedName = "SUPPLIER" },
                new IdentityRole { Name = "technicalsupport", NormalizedName = "TECHNICALSUPPORT" }
            );
        }
    }
}

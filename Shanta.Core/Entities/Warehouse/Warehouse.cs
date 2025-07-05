using Shanta.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Warehouse
{
    public class Warehouse : BaseEntity
    {
        public string Name { get; set; } // Name of the warehouse
        public string Location { get; set; } // Physical location of the warehouse
        public string? Description { get; set; } // Optional description of the warehouse

        public string Address { get; set; } // Address of the warehouse

        public string ManagerId { get; set; } // ID of the warehouse manager (FK)

        [ForeignKey("ManagerId")]
        public AppUser? Manager { get; set; } // Navigation property for the warehouse manager
    }
}

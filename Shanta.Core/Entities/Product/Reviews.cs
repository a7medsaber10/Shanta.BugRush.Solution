using Shanta.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Product
{
    public class Reviews : BaseEntity
    {
        [Range(1, 5)]
        public int Rating { get; set; }

        public string? Comment { get; set; }
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }

        public string UserId { get; set; } // FK to User entity

        [ForeignKey("UserId")]

        public AppUser? User { get; set; } // Navigation property for User entity
    }
}

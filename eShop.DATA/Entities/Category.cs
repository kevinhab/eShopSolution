using eShop.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.DATA.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? SeoAlias { get; set; }
        public string? Description { get; set; }
        public int? ParentId { get; set; } // Nullable for root categories
        public DateTime DateCreated { get; set; }
        public int DisplayOrder { get; set; } = 0;
        
        public Status Status { get; set; } // Using class Status enum for category status

    }
}

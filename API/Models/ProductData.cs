using Entities.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class ProductData
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Condition { get; set; }
        public string Location { get; set; }

        public int UserId { get; set; } // nueva propiedad

        [ForeignKey("UserId")]
        public virtual UserItem User { get; set; } // nueva propiedad

    }
}

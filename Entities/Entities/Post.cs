using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Entities.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
       
        public string Title { get; set; }

        [Column(TypeName = "varchar(500)")]
      
        public string Description { get; set; }

        [Column(TypeName = "Datetime")]
        
        public DateTime AddedDate { get; set; }

        public int UserId { get; set; }

        //Propiedades de navegación
        //[JsonIgnore]
        //public UserItem UserItem { get; set; }
    }
}

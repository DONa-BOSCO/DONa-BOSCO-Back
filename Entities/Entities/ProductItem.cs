
using API.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    public class ProductItem
    {
        public ProductItem()
        {

            IsActive = true;
            IsPublic = true;

        }

        public int Id { get; set; }
      
        public int IdPhotoFile { get; set; }
        public Guid IdWeb { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Condition { get; set; }
        public string Location { get; set; }

        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }

        public DateTime UpdateDate { get; set; }
        public DateTime AddedDate { get; set; }
        //[NotMapped]
        //public Base64FileModel Base64FileModel { get; set; }
        
    }
    public class Base64FileModel
    {
        public string FileName { get; set; }
        public string Content { get; set; }
        public FileExtensionEnum FileExtension { get; set; }
    }

    public class ProductInfoModel
    {
        public ProductItem ProducItem { get; set; }
        public Base64FileModel Base64FileModel { get; set; }
    }

}

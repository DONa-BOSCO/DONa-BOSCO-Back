using Entities.Entities;

namespace API.Models
{
    public class ProductForm
    { 
        
            public string Title { get; set; }
            public int IdPhotoFile { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Condition { get; set; }
        public string Location { get; set; }
        public ProductItem ToProductItem()
            {
            ProductItem productItem = new ProductItem();

            productItem.Title = Title;
            productItem.Description = Description;
            productItem.Category = Category;
            productItem.Condition = Condition;
            productItem.Location = Location;



            productItem.AddedDate = DateTime.Now;
                productItem.UpdateDate = DateTime.Now;
                productItem.IsActive = true;
                productItem.IsPublic = true;
                return productItem;
            }
        }
    }



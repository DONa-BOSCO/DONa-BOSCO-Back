namespace API.Models
{
    public class ProductUploadModel
    {
        public ProductUploadModel()
        {

            IsActive = true;
            IsPublic = true;

        }

        public int Id { get; set; }

        public int IdPhotoFile { get; set; }
        //public virtual FileItem PhotoFile { get; set; }
        public Guid IdWeb { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Condition { get; set; }
        public string Location { get; set; }

        public IFormFile Image { get; set; }

        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }

        public DateTime UpdateDate { get; set; }
        public DateTime AddedDate { get; set; }
    }
}

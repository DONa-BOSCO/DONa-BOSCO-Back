using API.Enums;

namespace API.Models
{
    public class Base64FileModel
    {
        public string FileName { get; set; }
        public string Content { get; set; }
        public FileExtensionEnum FileExtension { get; set; }
    }
}

using Data;
using Entities.Entities;

namespace API.Models
{
    public class PostForm
    {
        public string Title { get; set; }
        public string Description { get; set; }
      
       

        public async Task<Post> ToPost()
        {


            Post post = new Post();

            post.Title = Title;
            post.Description = Description;
            post.AddedDate = DateTime.Now;
            


            return post;
        }
    }
}

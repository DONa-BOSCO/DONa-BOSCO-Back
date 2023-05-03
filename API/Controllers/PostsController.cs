using API.Attributes;
using API.Models;
using Data;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
   
    [ApiController]

   
    [Route("[controller]/[action]")]
    public class PostsController : ControllerBase
    {

        private readonly ServiceContext context;

        public PostsController(ServiceContext context)
        {
            this.context = context;
        }
        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpGet]
        public async Task<List<Post>> Get()
        {
            return await context.Posts.ToListAsync();
            //return await context.Posts.Include(x => x.Autor).ToListAsync(); //Descomentar si se quiere traer los autores también
        }
        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Post>> Get(int id)
        {
            var existe = await context.Posts.AnyAsync(x => x.Id == id);
            if (!existe)
                return NotFound($"El Post con id {id} no existe");

            return await context.Posts.Include(x => x.UserId).FirstOrDefaultAsync(x => x.Id == id); //el include trae data relacionada
        }
        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPost(Name = "Post")]
        public async Task<ActionResult> AddPost([FromBody] NewPostRequestModel newPostRequestModel)
        {
            try
            {

                //var UserId = await context.Set<UserItem>()
                //.Where(u => u.Email == newPostRequestModel.PostData.Email)
                //.Select(u => u.Id)
                //.FirstOrDefaultAsync();


                var post = new Post();
               post.Id = newPostRequestModel.PostData.Id;
                post.Title = newPostRequestModel.PostData.Title;
                post.Description = newPostRequestModel.PostData.Description;
                //post.Email = newPostRequestModel.PostData.Email;
                //post.UserId = UserId;



                await context.Posts.AddAsync(post);
                await context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }


        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, Post post)
        {
            if (id != post.Id)
                return BadRequest("Los id no coinciden");
            var existe = await context.Posts.AnyAsync(x => x.Id == id);
            if (!existe)
                return NotFound("El post que se quiere actualizar no existe");

            context.Posts.Update(post);
            await context.SaveChangesAsync();
            return Ok();
        }
        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            context.Posts.Remove(new Post { Id = id });
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}

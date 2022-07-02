using System.Collections.Generic;
using System.Threading.Tasks;
using JsonPlaceHolderAsyncDemo.Models;

namespace JsonPlaceHolderAsyncDemo.ExternalServices
{
    public interface IJsonPlaceHolderService
    {
        Task<IEnumerable<Album>> GetAlbuns();
        Task<IEnumerable<Comment>> GetComments();
        Task<IEnumerable<Photo>> GetPhotos();
        Task<IEnumerable<Post>> GetPosts();
        Task<IEnumerable<Todo>> GetTodos();
        Task<IEnumerable<User>> GetUsers();

    }
}
using System.Collections.Generic;

namespace JsonPlaceHolderAsyncDemo.Models
{
    public class DadosCompletos
    {
        public IEnumerable<Album> Albums { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Todo> Todos { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
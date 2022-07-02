using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using JsonPlaceHolderAsyncDemo.Models;
using Newtonsoft.Json;

namespace JsonPlaceHolderAsyncDemo.ExternalServices
{
    public class JsonPlaceHolderService : IJsonPlaceHolderService
    {
        private readonly HttpClient _httpClient;

        public JsonPlaceHolderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
        }

        public async Task<IEnumerable<Album>> GetAlbuns()
        {
            var response = await _httpClient.GetAsync($"albums");
            var readAsStringAsync = await response.Content.ReadAsStringAsync();
            var albums = JsonConvert.DeserializeObject<IEnumerable<Album>>(readAsStringAsync);
            return albums;
        }

        public async Task<IEnumerable<Comment>> GetComments()
        {
            var response = await _httpClient.GetAsync($"comments");
            var readAsStringAsync = await response.Content.ReadAsStringAsync();
            var coments = JsonConvert.DeserializeObject<IEnumerable<Comment>>(readAsStringAsync);
            return coments;
        }

        public async Task<IEnumerable<Photo>> GetPhotos()
        {
            var response = await _httpClient.GetAsync($"photos");
            var readAsStringAsync = await response.Content.ReadAsStringAsync();
            var photos = JsonConvert.DeserializeObject<IEnumerable<Photo>>(readAsStringAsync);
            return photos;
        }

        public async Task<IEnumerable<Post>> GetPosts()
        {
            var response = await _httpClient.GetAsync($"posts");
            var readAsStringAsync = await response.Content.ReadAsStringAsync();
            var posts = JsonConvert.DeserializeObject<IEnumerable<Post>>(readAsStringAsync);
            return posts;
        }

        public async Task<IEnumerable<Todo>> GetTodos()
        {
            var response = await _httpClient.GetAsync($"todos");
            var readAsStringAsync = await response.Content.ReadAsStringAsync();
            var todos = JsonConvert.DeserializeObject<IEnumerable<Todo>>(readAsStringAsync);
            return todos;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var response = await _httpClient.GetAsync($"users");
            var readAsStringAsync = await response.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<IEnumerable<User>>(readAsStringAsync);
            return users;
        }
    }
}
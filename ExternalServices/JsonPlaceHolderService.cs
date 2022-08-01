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
        private const string Uri = "https://jsonplaceholder.typicode.com/";

        public JsonPlaceHolderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(Uri);
        }

        public async Task<IEnumerable<Album>> GetAlbuns()
        {
            var httpResponseMessage = await _httpClient.GetAsync($"albums");
            var readAsStringAsync = await httpResponseMessage.Content.ReadAsStringAsync();
            var albumsList = JsonConvert.DeserializeObject<IEnumerable<Album>>(readAsStringAsync);
            return albumsList;
        }

        public async Task<IEnumerable<Comment>> GetComments()
        {
            var httpResponseMessage = await _httpClient.GetAsync($"comments");
            var readAsStringAsync = await httpResponseMessage.Content.ReadAsStringAsync();
            var comentsList = JsonConvert.DeserializeObject<IEnumerable<Comment>>(readAsStringAsync);
            return comentsList;
        }

        public async Task<IEnumerable<Photo>> GetPhotos()
        {
            var httpResponseMessage = await _httpClient.GetAsync($"photos");
            var readAsStringAsync = await httpResponseMessage.Content.ReadAsStringAsync();
            var photosList = JsonConvert.DeserializeObject<IEnumerable<Photo>>(readAsStringAsync);
            return photosList;
        }

        public async Task<IEnumerable<Post>> GetPosts()
        {
            var httpResponseMessage = await _httpClient.GetAsync($"posts");
            var readAsStringAsync = await httpResponseMessage.Content.ReadAsStringAsync();
            var postsList = JsonConvert.DeserializeObject<IEnumerable<Post>>(readAsStringAsync);
            return postsList;
        }

        public async Task<IEnumerable<Todo>> GetTodos()
        {
            var httpResponseMessage = await _httpClient.GetAsync($"todos");
            var readAsStringAsync = await httpResponseMessage.Content.ReadAsStringAsync();
            var todosList = JsonConvert.DeserializeObject<IEnumerable<Todo>>(readAsStringAsync);
            return todosList;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var httpResponseMessage = await _httpClient.GetAsync($"users");
            var readAsStringAsync = await httpResponseMessage.Content.ReadAsStringAsync();
            var usersList = JsonConvert.DeserializeObject<IEnumerable<User>>(readAsStringAsync);
            return usersList;
        }
    }
}
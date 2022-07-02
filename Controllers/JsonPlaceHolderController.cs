using System.Diagnostics;
using System.Threading.Tasks;
using JsonPlaceHolderAsyncDemo.ExternalServices;
using JsonPlaceHolderAsyncDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace JsonPlaceHolderAsyncDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JsonPlaceHolderController : ControllerBase
    {
        private readonly IJsonPlaceHolderService _jsonPlaceHolderService;

        public JsonPlaceHolderController(IJsonPlaceHolderService jsonPlaceHolderService)
        {
            _jsonPlaceHolderService = jsonPlaceHolderService;
        }

        [HttpGet("exemplo1_sincrono")]
        public IActionResult Exemplo1Sincrono()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            
            var albums = _jsonPlaceHolderService.GetAlbuns().Result;
            var comments = _jsonPlaceHolderService.GetComments().Result;
            var photos = _jsonPlaceHolderService.GetPhotos().Result;
            var posts = _jsonPlaceHolderService.GetPosts().Result;
            var todos = _jsonPlaceHolderService.GetTodos().Result;
            var users = _jsonPlaceHolderService.GetUsers().Result;
            
            var dados = new DadosCompletos()
            {
                Albums = albums,
                Comments = comments,
                Photos = photos,
                Posts = posts,
                Todos = todos,
                Users = users
            };
            
            stopwatch.Stop();
            
            return Ok(dados);
        }
        
        [HttpGet("exemplo2_sincrono")]
        public async Task<IActionResult> Exemplo2Assincrono()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            
            var albums = await _jsonPlaceHolderService.GetAlbuns();
            var comments = await _jsonPlaceHolderService.GetComments();
            var photos = await _jsonPlaceHolderService.GetPhotos();
            var posts = await _jsonPlaceHolderService.GetPosts();
            var todos = await _jsonPlaceHolderService.GetTodos();
            var users = await _jsonPlaceHolderService.GetUsers();
            
            var dados = new DadosCompletos()
            {
                Albums = albums,
                Comments = comments,
                Photos = photos,
                Posts = posts,
                Todos = todos,
                Users = users
            };
            
            stopwatch.Stop();
            
            return Ok(dados);
        }
        
        [HttpGet("exemplo3_sincrono")]
        public async Task<IActionResult> Exemplo3Assincrono()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            
            var albums = _jsonPlaceHolderService.GetAlbuns();
            var comments = _jsonPlaceHolderService.GetComments();
            var photos = _jsonPlaceHolderService.GetPhotos();
            var posts = _jsonPlaceHolderService.GetPosts();
            var todos = _jsonPlaceHolderService.GetTodos();
            var users = _jsonPlaceHolderService.GetUsers();
            
            var dados = new DadosCompletos
            {
                Albums = await albums,
                Comments = await comments,
                Photos = await photos,
                Posts = await posts,
                Todos = await todos,
                Users = await users
            };
            
            stopwatch.Stop();
            
            return Ok(dados);
        }
    }
}
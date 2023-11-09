using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TezAPI.Application.Repositories;
using TezAPI.Application.ViewModel.Users;
using TezAPI.Domain.Entities;
using TezAPI.Persistence.Repository;

namespace TezAPI.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        readonly private IUserWriteRepository _uWriteRepository;
        readonly private IUserReadRepository _uReadRepository;
        readonly private IMapper _mapper;
        public UsersController(IUserWriteRepository uWriteRepository, IUserReadRepository uReadRepository,IMapper mapper)
        {
            _uWriteRepository = uWriteRepository;
            _uReadRepository = uReadRepository;
            _mapper = mapper;
            
        }

        [HttpGet]
        public  IActionResult Get()

        {
            var entity = _uReadRepository.GetWhere(i=>i.Id==  Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10")).FirstOrDefault();
           //var json = JsonConvert.SerializeObject(entity);
            return Ok(entity);
        }


        //[HttpPost]
        //public async Task<IActionResult>Post(UserRegistryModel model)

        //{
        //    var u = _mapper.Map<User>(model);

        //Console.WriteLine(u.Id);
        //var categoryList = new List<Category>()
        //{
        //    new Category (){ CategoryName="tatlı",CreatedDate=DateTime.UtcNow,  Id = Guid.NewGuid()}
        //    ,
        //    new Category (){ CategoryName="uzakdoğu mutfağı",CreatedDate=DateTime.UtcNow,  Id = Guid.NewGuid()}
        //};

        //var uList = new List<User>()
        //{
        //    new User (){ CreatedDate=DateTime.UtcNow,  Id = Guid.NewGuid()}
        //    ,
        //    new User (){ CreatedDate=DateTime.UtcNow,  Id = Guid.NewGuid()}
        //};


        //var writer = new User()
        //{ CreatedDate = DateTime.UtcNow, Id = Guid.NewGuid() };


        //var iList = new List<Ingredient>()
        //{
        //    new Ingredient (){ CreatedDate=DateTime.UtcNow,  Id = Guid.NewGuid(),IngredientName="a",IngredientType="b",StockAmount=5,Unit="1" }
        //    ,
        //    new Ingredient (){ CreatedDate=DateTime.UtcNow,  Id = Guid.NewGuid(),IngredientName="a",IngredientType="b",StockAmount=5,Unit="1"}
        //};

        //var stockList = new List<Stock>()
        //{
        //    new Stock (){ CreatedDate=DateTime.UtcNow,  Id = Guid.NewGuid(),StockAmount=3,UserId= Guid.NewGuid() }
        //    ,
        //    new Stock (){ CreatedDate=DateTime.UtcNow,  Id = Guid.NewGuid(),StockAmount=10,UserId= Guid.NewGuid()}
        //};




        //var recipeList = new List<Recipe>() { new Recipe() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, IngredientId = Guid.NewGuid(), CookingTime = 1, IsItFavorite = false, PreparationTime = 2, RecipeText = "asdfgg",Writer=writer,Categories= categoryList,Ingredients=iList } };
        //await _uWriteRepository.AddRangeAsync(new()
        //{ new() { Id=Guid.NewGuid(),CreatedDate=DateTime.UtcNow,Recipes=recipeList},
        //new() { Id=Guid.NewGuid(),CreatedDate=DateTime.UtcNow }, });

        //var count = await _uWriteRepository.SaveAsync();
        //return Ok();
        // }

    }

}




using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TezAPI.Application.Repositories;
using TezAPI.Application.RequestParameters;
using TezAPI.Domain.Entities;

namespace TezAPI.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {

        readonly private IRecipeWriteRepository _rWriteRepository;
        readonly private IRecipeReadRepository _rReadRepository;

        public RecipeController(IRecipeWriteRepository rWriteRepository, IRecipeReadRepository rReadRepository)
        {
            _rWriteRepository = rWriteRepository;
            _rReadRepository = rReadRepository;
        }

         [HttpGet]
        public   IActionResult Get([FromQuery]Pagination pagination)
        {
            var totalCount= _rReadRepository.GetAll().Count();
            var response =_rReadRepository.GetAll().Skip(pagination.Page*pagination.Total).Take(pagination.Total);
            return Ok(new
            {
                response,
                totalCount
            });}

        [HttpPost] 
        public async Task<IActionResult> Post()
        {
            var c= new Category() { Id =  Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CategoryName = "Kastamonu Mutfağı"};
            var i = new Ingredient() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, StockAmount = 2, IngredientName = "fasülye", IngredientType = "sebze", Unit = "kilo" };
            var i2 = new Ingredient() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, StockAmount = 300, IngredientName = "fındık", IngredientType = "kuru yemiş", Unit = "gram" };
            var i3 = new Ingredient() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, StockAmount = 3, IngredientName = "bamya", IngredientType = "sebze", Unit = "kilo" };
            var us = new User() { Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa33"), CreatedDate = DateTime.UtcNow };
            var recipe = new Recipe() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CookingTime = 10, IsItFavorite = false, PreparationTime = 10, RecipeText = "a" ,UserId=Guid.Parse(("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa33")) };
            recipe.Categories.Add(c);
            recipe.Ingredients.Add(i);
            recipe.Ingredients.Add(i2);
            recipe.Ingredients.Add(i3);

            //c.Recipes.Add(recipe);
            //i.Recipes.Add(recipe);
            //i2.Recipes.Add(recipe);
            //i3.Recipes.Add(recipe);

                await _rWriteRepository.AddAsync(recipe);
            await _rWriteRepository.SaveAsync();

            return Ok(recipe);



        }





    }
}

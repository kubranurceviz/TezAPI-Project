using Microsoft.AspNetCore.Mvc;
using TezAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;

namespace TezAPI.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        readonly private IShoppingListWriteRepository _slWriteRepository;
        readonly private IShoppingListReadRepository _slReadRepository;
        readonly private IRecipeWriteRepository _rWriteRepository;
        readonly private IRecipeReadRepository _rReadRepository;
        public HomeController(IShoppingListWriteRepository slWriteRepository, IShoppingListReadRepository slReadRepository, IRecipeReadRepository rReadRepository,IRecipeWriteRepository rWriteRepository)
        {
            _slWriteRepository = slWriteRepository;
            _slReadRepository = slReadRepository;

            _rReadRepository = rReadRepository;
            _rWriteRepository = rWriteRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
          
        {
            //await _slWriteRepository.AddRangeAsync(new()
            //{ new() { Id=Guid.NewGuid(),CreatedDate=DateTime.UtcNow, Title="abcd", ShoppingListText="abansndm",UserId=Guid.NewGuid()},
            //new() { Id=Guid.NewGuid(),CreatedDate=DateTime.UtcNow, Title="abcefgd", ShoppingListText="mfmföf",UserId=Guid.NewGuid()}, });

            var entity=_rReadRepository.GetAll();
            
            //var count = await _slWriteRepository.SaveAsync();
            return Ok(entity);
            }
        }
    }


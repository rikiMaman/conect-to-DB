using Microsoft.AspNetCore.Mvc;
using Store.BL;
using Store.Model.Model;

namespace Lesson6.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        readonly IItemsService _iitemService;
        public ItemController(IItemsService IItemsService)
        {
            _iitemService = IItemsService;

        }
        protected IEnumerable<Item> Get()
        {
            return _iitemService.GetAll();
        }
    }
}
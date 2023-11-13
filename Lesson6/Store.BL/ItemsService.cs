using Store.DAL;
using Store.Model;
using Store.Model.Model;

namespace Store.BL
{
    public class ItemsService :IItemsService
    {
        readonly DAL.IitemRepository _iitemRepository;
        public ItemsService(DAL.IitemRepository iItemsService)
        {
            _iitemRepository= iItemsService;
        }

        public List<Item> GetAll()
        {
            return _iitemRepository.GetAll();
        }

        
    }
}  
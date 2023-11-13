using Store.Model;
using Store.Model.Model;

namespace Store.DAL
{
    public class ItemRepository: IitemRepository
    {
        readonly StoreContext _StoreContext;
        public ItemRepository(StoreContext storeContext)
        {
            _StoreContext = storeContext;
        }
        public List<Item> GetAll()
        {
            return _StoreContext.Items.ToList();
        }
    }
}
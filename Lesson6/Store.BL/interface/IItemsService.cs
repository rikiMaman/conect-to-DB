using Store.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.BL
{
    public interface IItemsService
    {
        List<Item> GetAll();
    }
}

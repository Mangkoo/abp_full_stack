using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Mangkoo.FullStack.MerchItem
{
    public interface IMerchItemRepository : IRepository // need <>?
    {
        Task<MerchItem> Get(string id);

        //IEnumerable or pageresult?
        Task<IEnumerable<MerchItem>> GetAll();
    }
}

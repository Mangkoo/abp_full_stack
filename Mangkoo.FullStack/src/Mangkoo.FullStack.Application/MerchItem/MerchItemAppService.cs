using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace Mangkoo.FullStack.MerchItem
{
    //[Authorize(BookStorePermissions.Books.Default)]
    public class MerchItemAppService
    {
        public required IMerchItemRepository MerchItemRepository { protected get; init; }

        public async Task<MerchItemDto> Get(string id)
        {
            // Dummy Id
            id = "1";

            // This needs to be a method in the Repository.
            var merchItem = await MerchItemRepository.Get(id);

            // Just some dummy data for now.
            MerchItemDto dummyItem = new MerchItemDto() { 
                Id = "1",
                Name = "Cool T-shirt",
                Price = 34.99,
                Description = "A cool shirt you can buy." 
            };

            return dummyItem;
        }

        public async Task<PagedResultDto<MerchItemDto>> GetAll()
        {
            //todo - just some dummy data for now.

            MerchItemDto dummyItem1 = new MerchItemDto()
            {
                Id = "2",
                Name = "Epic Keyring",
                Price = 2.99,
                Description = "An epic keyring thing."
            };

            MerchItemDto dummyItem2 = new MerchItemDto()
            {
                Id = "3",
                Name = "Amazing Sticker",
                Price = 4.99,
                Description = "An aweosme sticker that's very sticky."
            };

            // Dummy data.
            var list = new List<MerchItemDto>();
            list.Add(dummyItem1);
            list.Add(dummyItem2);

            return new PagedResultDto<MerchItemDto>(
               2,
               list
           );
        }

    }
}

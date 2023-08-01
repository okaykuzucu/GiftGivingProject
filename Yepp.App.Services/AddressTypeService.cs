using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public class AddressTypeService : IAddressTypeService
    {
        private readonly IAddressTypeEntityStore _addressTypeEntityStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTypeService"/> class.
        /// </summary>
        /// <param name="addressTypeEntityStore">The address type entity store.</param>
        public AddressTypeService(IAddressTypeEntityStore addressTypeEntityStore)
        {
            _addressTypeEntityStore = addressTypeEntityStore;
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="addressTypeAddOptions">The address type add options.</param>
        /// <returns></returns>
        public async Task<AddressType> AddAsync(AddressTypeAddOptions addressTypeAddOptions)
        {
            var addressTypeEntity = new AddressTypeEntity
            {
                Type = addressTypeAddOptions.Type
            };

            addressTypeEntity = await _addressTypeEntityStore.AddAsync(addressTypeEntity);

            var addressType = new AddressType(addressTypeEntity);

            return addressType;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        public async Task DeleteByIdAsync(Guid guid)
        {
            await _addressTypeEntityStore.DeleteByIdAsync(guid);
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<AddressType> GetDetail(Guid guid)
        {
            var addressTypeEntity = await _addressTypeEntityStore.GetDetail(guid);
            var addressType = new AddressType(addressTypeEntity);
            return addressType;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<AddressType>> ListAsync()
        {
            var addressTypeEntityList = await _addressTypeEntityStore.ListAsync();
            var addressTypeList = addressTypeEntityList.Select(x => new AddressType(x));

            return addressTypeList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="addressTypeUpdateOptions">The address type update options.</param>
        /// <returns></returns>
        public async Task<AddressType> UpdateByIdAsync(Guid guid, AddressTypeUpdateOptions addressTypeUpdateOptions)
        {
            var addressTypeEntity = await _addressTypeEntityStore.FetchByIdAsync(guid);
            addressTypeEntity.Type = addressTypeUpdateOptions.Type;

            addressTypeEntity = await _addressTypeEntityStore.UpdateByIdAsync(guid, addressTypeEntity);

            var addressType = new AddressType(addressTypeEntity);

            return addressType;
        }
    }
}

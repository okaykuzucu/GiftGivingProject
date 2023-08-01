using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{  
    public class AddressService : IAddressService
    {
        private readonly IAddressEntityStore _addressEntityStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressService"/> class.
        /// </summary>
        /// <param name="addressEntityStore">The address entity store.</param>
        public AddressService(IAddressEntityStore addressEntityStore)
        {
            _addressEntityStore = addressEntityStore;
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="addressAddOptions">The address add options.</param>
        /// <returns></returns>
        public async Task<Address> AddAsync(AddressAddOptions addressAddOptions)
        {
            var addressEntity = new AddressEntity
            {
                AddressTypeId = addressAddOptions.AddressTypeId,
                CityId = addressAddOptions.CityId,
                CountryId = addressAddOptions.CountryId,
                CreatedDate = addressAddOptions.CreatedDate,
                Name = addressAddOptions.Name,
                AddressLine1 = addressAddOptions.AddressLine1,
                AddressLine2 = addressAddOptions.AddressLine2,
                UserId = addressAddOptions.UserId,
                Zipcode = addressAddOptions.Zipcode                                                                        
            };
            addressEntity = await _addressEntityStore.AddAsync(addressEntity);

            var address = new Address(addressEntity);

            return address;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        public async Task DeleteByIdAsync(Guid guid)
        {
            await _addressEntityStore.DeleteByIdAsync(guid);
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<Address> GetDetail(Guid guid)
        {
            var addressEntity = await _addressEntityStore.GetDetail(guid);
            var address = new Address(addressEntity);
            return address;
        }

        /// <summary>
        /// Gets the user by addresses.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        public async Task<IEnumerable<Address>> GetUserByAddresses(Guid userId)
        {
            var userAddressListResult = await _addressEntityStore.GetUserByAddresses(userId);

            return 
                userAddressListResult.Select(x => new Address(x));
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Address>> ListAsync()
        {
            var addressEntityList = await _addressEntityStore.ListAsync();
            var addressList = addressEntityList.Select(x => new Address(x));

            return addressList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="addressUpdateOptions">The address update options.</param>
        /// <returns></returns>
        public async Task<Address> UpdateByIdAsync(Guid guid, AddressUpdateOptions addressUpdateOptions)
        {
            var addressEntity = await _addressEntityStore.FetchByIdAsync(guid);
            addressEntity.AddressTypeId = addressUpdateOptions.AddressTypeId;
            addressEntity.CityId = addressUpdateOptions.CityId;
            addressEntity.CountryId = addressUpdateOptions.CountryId;
            addressEntity.Name = addressUpdateOptions.Name;
            addressEntity.AddressLine1 = addressUpdateOptions.AddressLine1;
            addressEntity.AddressLine2 = addressUpdateOptions.AddressLine2;
            addressEntity.UpdatedDate = addressUpdateOptions.UpdatedDate;
            addressEntity.UserId = addressUpdateOptions.UserId;
            addressEntity.Zipcode = addressUpdateOptions.Zipcode;

            addressEntity = await _addressEntityStore.UpdateByIdAsync(guid, addressEntity);

            var address = new Address(addressEntity);

            return address;
        }
    }
}


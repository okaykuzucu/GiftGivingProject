using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryEntityStore _countryEntityStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserService" /> class.
        /// </summary>
        /// <param name="countryEntityStore">The country entity store.</param>
        public CountryService(ICountryEntityStore countryEntityStore)
        {
            _countryEntityStore = countryEntityStore;
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="countryAddOptions">The country add options.</param>
        /// <returns></returns>
        public async Task<Country> AddAsync(CountryAddOptions countryAddOptions)
        {
            var countryEntity = new CountryEntity
            {
                Name = countryAddOptions.Name      
            };

            countryEntity = await _countryEntityStore.AddAsync(countryEntity);

            var country = new Country(countryEntity);

            return country;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        public async Task DeleteByIdAsync(Guid guid)
        {
            await _countryEntityStore.DeleteByIdAsync(guid);
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<Country> GetDetail(Guid guid)
        {
            var countryEntity = await _countryEntityStore.GetDetail(guid);
            var country = new Country(countryEntity);
            return country;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Country>> ListAsync()
        {
            var countryEntityList = await _countryEntityStore.ListAsync();
            var countryList = countryEntityList.Select(x => new Country(x));

            return countryList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="countryUpdateOptions">The country update options.</param>
        /// <returns></returns>
        public async Task<Country> UpdateByIdAsync(Guid guid, CountryUpdateOptions countryUpdateOptions)
        {
            var countryEntity = await _countryEntityStore.FetchByIdAsync(guid);
            countryEntity.Name = countryUpdateOptions.Name;

            countryEntity = await _countryEntityStore.UpdateByIdAsync(guid, countryEntity);

            var country = new Country(countryEntity);

            return country;
        }
    }
}

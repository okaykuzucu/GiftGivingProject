using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public class CityService : ICityService
    {
        /// <summary>
        /// The city entity store
        /// </summary>
        private readonly ICityEntityStore _cityEntityStore;


        /// <summary>
        /// Initializes a new instance of the <see cref="UserService" /> class.
        /// </summary>
        /// <param name="cityEntityStore">The city entity store.</param>
        public CityService(ICityEntityStore cityEntityStore)
        {
            _cityEntityStore = cityEntityStore;
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="cityAddOptions">The city add options.</param>
        /// <returns></returns>
        public async Task<City> AddAsync(CityAddOptions cityAddOptions)
        {
            var cityEntity = new CityEntity
            {
                Name = cityAddOptions.Name,
            };

            cityEntity = await _cityEntityStore.AddAsync(cityEntity);

            var city = new City(cityEntity);

            return city;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        public async Task DeleteByIdAsync(Guid guid)
        {
            await _cityEntityStore.DeleteByIdAsync(guid);
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<City> GetDetail(Guid guid)
        {
            var cityEntity = await _cityEntityStore.GetDetail(guid);

            var city = new City(cityEntity);

            return city;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<City>> ListAsync()
        {
            var cityEntityList = await _cityEntityStore.ListAsync();
            var cityList = cityEntityList.Select(x => new City(x));

            return cityList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="cityUpdateOptions">The city update options.</param>
        /// <returns></returns>
        public async Task<City> UpdateByIdAsync(Guid guid, CityUpdateOptions cityUpdateOptions)
        {
            var cityEntity = await _cityEntityStore.FetchByIdAsync(guid);
            cityEntity.Name = cityUpdateOptions.Name;

            cityEntity = await _cityEntityStore.UpdateByIdAsync(guid, cityEntity);

            var city = new City(cityEntity);

            return city;
        }
    }
}

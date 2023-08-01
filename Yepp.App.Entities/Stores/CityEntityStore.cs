using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Yepp.App.Entities.BaseEntityStore" />
    /// <seealso cref="Yepp.App.Entities.Stores.ICityEntityStore" />
    public class CityEntityStore : BaseEntityStore, ICityEntityStore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CityEntityStore"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public CityEntityStore(EntitiesDbContext dbContext)
         : base(dbContext)
        {
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<CityEntity> AddAsync(CityEntity document)
        {
            await _dbContext.Cities.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            var cityEntity =
           await _dbContext.Cities.FindAsync(id);

            if (cityEntity != null)
            {
                _dbContext.Cities.Remove(cityEntity);

                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<CityEntity> FetchByIdAsync(Guid id)
        {
            var cityEntity =
                await _dbContext.Cities.FindAsync(id);

            return cityEntity;

        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<CityEntity> GetDetail(Guid guid)
        {
            var cityEntity = await _dbContext.Cities.Where(x => x.Id == guid).FirstOrDefaultAsync();

            return cityEntity;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CityEntity>> ListAsync()
        {
            var cityEntityList =
          await _dbContext.Cities.ToListAsync();

            return cityEntityList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<CityEntity> UpdateByIdAsync(Guid id, CityEntity document)
        {
            var cityEntityToUpdate =
            await _dbContext.Cities.FindAsync(id);
            cityEntityToUpdate.Id = document.Id;
            cityEntityToUpdate.Name = document.Name;
            await _dbContext.SaveChangesAsync();

            try
            {

                await Task.Run(() => _dbContext.Cities.Update(cityEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }

            return cityEntityToUpdate;

        }
    }
}

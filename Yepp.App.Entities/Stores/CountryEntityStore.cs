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
    /// <seealso cref="Yepp.App.Entities.Stores.ICountryEntityStore" />
    public class CountryEntityStore : BaseEntityStore, ICountryEntityStore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryEntityStore"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public CountryEntityStore(EntitiesDbContext dbContext)
         : base(dbContext)
        {
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<CountryEntity> AddAsync(CountryEntity document)
        {
            await _dbContext.Countries.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            var countryEntity =
            await _dbContext.Countries.FindAsync(id);

            if (countryEntity != null)
            {
                _dbContext.Countries.Remove(countryEntity);

                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<CountryEntity> FetchByIdAsync(Guid id)
        {
            var countryEntity =
               await _dbContext.Countries.FindAsync(id);

            return countryEntity;
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<CountryEntity> GetDetail(Guid guid)
        {
            var countryEntity = await _dbContext.Countries.Where(x => x.Id == guid).FirstOrDefaultAsync();

            return countryEntity;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CountryEntity>> ListAsync()
        {
            var countryEntityList =
            await _dbContext.Countries.ToListAsync();

            return countryEntityList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<CountryEntity> UpdateByIdAsync(Guid id, CountryEntity document)
        {
           var countryEntityToUpdate =
           await _dbContext.Countries.FindAsync(id);
           countryEntityToUpdate.Id = document.Id;
           countryEntityToUpdate.Name = document.Name;

           await _dbContext.SaveChangesAsync();

            try
            {

                await Task.Run(() => _dbContext.Countries.Update(countryEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }

            return countryEntityToUpdate;

        }
    }
}


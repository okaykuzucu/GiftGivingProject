using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{

    /// <summary>
    /// the role entity store
    /// </summary>
    /// <seealso cref="Yepp.App.Entities.BaseEntityStore" />
    /// <seealso cref="Yepp.App.Entities.Stores.IAddressEntityStore" />
    public class AddressEntityStore : BaseEntityStore, IAddressEntityStore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressEntityStore"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public AddressEntityStore(EntitiesDbContext dbContext)
         : base(dbContext)
        {
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<AddressEntity> AddAsync(AddressEntity document)
        {
            await _dbContext.Addresses.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;

        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            var addressEntity =
                await _dbContext.Addresses.FindAsync(id);
            if(addressEntity != null)
            {
                _dbContext.Addresses.Remove(addressEntity);

                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<AddressEntity> FetchByIdAsync(Guid id)
        {
            var addressEntity =
                await _dbContext.Addresses.FindAsync(id);

            return addressEntity;
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<AddressEntity> GetDetail(Guid addressId)
        {
            var addressEntity = await _dbContext.Addresses.Where(x => x.Id == addressId).FirstOrDefaultAsync();

            return addressEntity;
        }

        public async Task<IEnumerable<AddressEntity>> GetUserByAddresses(Guid userId)
        {
            var userAddresses = await _dbContext.Addresses.Where(x => x.UserId == userId).ToListAsync();

            return userAddresses;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<AddressEntity>> ListAsync()
        {
            var addressEntityList = await _dbContext.Addresses.ToListAsync();

            return addressEntityList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<AddressEntity> UpdateByIdAsync(Guid id, AddressEntity document)
        {
            var addressEntityToUpdate =
            await _dbContext.Addresses.FindAsync(id);
            addressEntityToUpdate.AddressTypeId = document.AddressTypeId;
            addressEntityToUpdate.CityId = document.CityId;
            addressEntityToUpdate.CountryId = document.CountryId;
            addressEntityToUpdate.CreatedDate = document.CreatedDate;
            addressEntityToUpdate.Id = document.Id;
            addressEntityToUpdate.Name = document.Name;
            addressEntityToUpdate.AddressLine1 = document.AddressLine1;
            addressEntityToUpdate.AddressLine2 = document.AddressLine2;
            addressEntityToUpdate.UpdatedDate = DateTime.UtcNow;
            addressEntityToUpdate.UserId = document.UserId;
            addressEntityToUpdate.Zipcode = document.Zipcode;

            try
            {

                await Task.Run(() => _dbContext.Addresses.Update(addressEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }

            return addressEntityToUpdate;

        }
    }
}

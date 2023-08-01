using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    /// <summary>
    /// User entity store
    /// </summary>
    /// <seealso cref="Yepp.App.Entities.BaseEntityStore" />
    /// <seealso cref="Yepp.App.Entities.Stores.IUserEntityStore" />
    public class AddresTypeEntityStore : BaseEntityStore, IAddressTypeEntityStore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEntityStore"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public AddresTypeEntityStore(EntitiesDbContext dbContext)
            : base(dbContext)
        {
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<AddressTypeEntity> AddAsync(AddressTypeEntity document)
        {
            await _dbContext.AddressesTypes.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            var userEntity =
                await _dbContext.AddressesTypes.FindAsync(id);
            if (userEntity != null)
            {
                _dbContext.AddressesTypes.Remove(userEntity);
                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<AddressTypeEntity> FetchByIdAsync(Guid id)
        {
            var addressTypesEntity =
                await _dbContext.AddressesTypes.FindAsync(id);

            return addressTypesEntity;
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<AddressTypeEntity> GetDetail(Guid Id)
        {
            var addressTypeEntity = await _dbContext.AddressesTypes.Where(x => x.Id == Id).FirstOrDefaultAsync();

            return addressTypeEntity;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<AddressTypeEntity>> ListAsync()
        {
            var userEntityList =
                await _dbContext.AddressesTypes.ToListAsync();

            return userEntityList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<AddressTypeEntity> UpdateByIdAsync(Guid id, AddressTypeEntity document)
        {
            var addressTypeEntityToUpdate =
            await _dbContext.AddressesTypes.FindAsync(id);
            addressTypeEntityToUpdate.Id = document.Id;
            addressTypeEntityToUpdate.Type = document.Type;

            try
            {

                await Task.Run(() => _dbContext.AddressesTypes.Update(addressTypeEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }

            return addressTypeEntityToUpdate;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public class AcceptedMarketplacesServices : IAcceptedMarketplacesService
    {
        public readonly IAcceptedMarketplacesEntityStore _acceptedMarketplacesEntityStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptedMarketplacesServices"/> class.
        /// </summary>
        /// <param name="acceptedMarketplacesEntityStore">The accepted marketplaces entity store.</param>
        public AcceptedMarketplacesServices(IAcceptedMarketplacesEntityStore acceptedMarketplacesEntityStore)
        {
            _acceptedMarketplacesEntityStore = acceptedMarketplacesEntityStore;
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="acceptedMarketplacesAddOptions">The accepted marketplaces add options.</param>
        /// <returns></returns>
        public async Task<AcceptedMarketplaces> AddAsync(AcceptedMarketplacesAddOptions acceptedMarketplacesAddOptions)
        {
            var acceptedMarketplacesEntity = new AcceptedMarketplacesEntity
            {
                CreatedDate = DateTime.UtcNow,
                WebSite = acceptedMarketplacesAddOptions.WebSite,
                UpdatedDate = DateTime.UtcNow,
                Name = acceptedMarketplacesAddOptions.Name,
            };

            acceptedMarketplacesEntity = await _acceptedMarketplacesEntityStore.AddAsync(acceptedMarketplacesEntity);

            var acceptedMarketplaces = new AcceptedMarketplaces(acceptedMarketplacesEntity);

            return acceptedMarketplaces;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            await _acceptedMarketplacesEntityStore.DeleteByIdAsync(id);
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<AcceptedMarketplaces> GetDetail(Guid guid)
        {
            var acceptedMarketplacesEntity = await _acceptedMarketplacesEntityStore.GetDetail(guid);
            var acceptedMarketplaces = new AcceptedMarketplaces(acceptedMarketplacesEntity);

            return acceptedMarketplaces;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<AcceptedMarketplaces>> ListAsync()
        {
            var acceptedMarketplacesEntityList = await _acceptedMarketplacesEntityStore.ListAsync();
            var acceptedMarketplacesList = acceptedMarketplacesEntityList.Select(x => new AcceptedMarketplaces(x));

            return acceptedMarketplacesList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="acceptedMarketplacesUpdateOptions">The accepted marketplaces update options.</param>
        /// <returns></returns>
        public async Task<AcceptedMarketplaces> UpdateByIdAsync(Guid guid, AcceptedMarketplacesUpdateOptions acceptedMarketplacesUpdateOptions)
        {
            var acceptedMarketplacesEntity = await _acceptedMarketplacesEntityStore.FetchByIdAsync(guid);
            acceptedMarketplacesEntity.CreatedDate = DateTime.UtcNow;
            acceptedMarketplacesEntity.Name = acceptedMarketplacesUpdateOptions.Name;
            acceptedMarketplacesEntity.UpdatedDate = DateTime.UtcNow;
            acceptedMarketplacesEntity.WebSite = acceptedMarketplacesUpdateOptions.WebSite;

            acceptedMarketplacesEntity = await _acceptedMarketplacesEntityStore.UpdateByIdAsync(guid, acceptedMarketplacesEntity);

            var acceptedMarketplaces = new AcceptedMarketplaces(acceptedMarketplacesEntity);

            return acceptedMarketplaces;
        }
    }
}

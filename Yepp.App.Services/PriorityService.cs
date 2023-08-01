using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public class PriorityService : IPriorityService
    {
        private readonly IPriorityEntityStore _priorityEntityStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="PriorityService"/> class.
        /// </summary>
        /// <param name="priorityEntityStore">The priority entity store.</param>
        public PriorityService(IPriorityEntityStore priorityEntityStore)
        {
            _priorityEntityStore = priorityEntityStore;
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="PriorityAddOptions">The priority add options.</param>
        /// <returns>
        /// Role
        /// </returns>
        public async Task<Priority> AddAsync(PriorityAddOptions PriorityAddOptions)
        {
            var priorityEntity = new PriorityEntity
            {
                Rate = PriorityAddOptions.Rate

            };

            priorityEntity = await _priorityEntityStore.AddAsync(priorityEntity);
            var priority = new Priority(priorityEntity);

            return priority;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        public async Task DeleteByIdAsync(Guid guid)
        {
            await _priorityEntityStore.DeleteByIdAsync(guid);
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>
        /// Role
        /// </returns>
        public async Task<Priority> GetDetail(Guid guid)
        {
            var priorityEntity = await _priorityEntityStore.GetDetail(guid);
            var priority = new Priority(priorityEntity);
            return priority;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns>
        /// Role List
        /// </returns>
        public async Task<IEnumerable<Priority>> ListAsync()
        {
            var priorityEntityList = await _priorityEntityStore.ListAsync();
            var priorityList = priorityEntityList.Select(x => new Priority(x));


            return priorityList;
        }
    }
}

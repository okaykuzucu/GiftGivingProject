using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public class ReturningUsersFromEventInvitationService : IReturningUsersFromEventInvitationService
    {
        private readonly IReturningUsersFromEventInvitationEntityStore _returningUsersFromEventInvitationEntityStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressService" /> class.
        /// </summary>
        /// <param name="returningUsersFromEventInvitationEntityStore">The returning users from event invitation entity store.</param>
        public ReturningUsersFromEventInvitationService(IReturningUsersFromEventInvitationEntityStore returningUsersFromEventInvitationEntityStore)
        {
            _returningUsersFromEventInvitationEntityStore = returningUsersFromEventInvitationEntityStore;
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="returningUsersFromEventInvitationAddOptions"></param>
        /// <returns></returns>
        public async  Task<ReturningUsersFromEventInvitation> AddAsync(ReturningUsersFromEventInvitationAddOptions returningUsersFromEventInvitationAddOptions)
        {
            var returningUsersFromEventInvitationEntity = new ReturningUsersFromEventInvitationEntity
            {
                CreatedDate = returningUsersFromEventInvitationAddOptions.CreatedDate,
                InvitationChannelId = returningUsersFromEventInvitationAddOptions.InvitationChannelId,
                UpdatedDate = returningUsersFromEventInvitationAddOptions.UpdatedDate,
                UserId = returningUsersFromEventInvitationAddOptions.UserId
            };
            returningUsersFromEventInvitationEntity = await _returningUsersFromEventInvitationEntityStore.AddAsync(returningUsersFromEventInvitationEntity);

            var returningUsersFromEventInvitation = new ReturningUsersFromEventInvitation(returningUsersFromEventInvitationEntity);

            return returningUsersFromEventInvitation;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        public async Task DeleteByIdAsync(Guid guid)
        {
            await _returningUsersFromEventInvitationEntityStore.DeleteByIdAsync(guid);
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<ReturningUsersFromEventInvitation> GetDetail(Guid guid)
        {
            var returningUsersFromEventInvitationEntity = await _returningUsersFromEventInvitationEntityStore.GetDetail(guid);
            var returningUsersFromEventInvitation = new ReturningUsersFromEventInvitation(returningUsersFromEventInvitationEntity);
            return returningUsersFromEventInvitation;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ReturningUsersFromEventInvitation>> ListAsync()
        {
            var returningUsersFromEventInvitationEntityList = await _returningUsersFromEventInvitationEntityStore.ListAsync();
            var returningUsersFromEventInvitationList = returningUsersFromEventInvitationEntityList.Select(x => new ReturningUsersFromEventInvitation(x));

            return returningUsersFromEventInvitationList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="returningUsersFromEventInvitationUpdateOptions"></param>
        /// <returns></returns>
        public async Task<ReturningUsersFromEventInvitation> UpdateByIdAsync(Guid guid, ReturningUsersFromEventInvitationUpdateOptions returningUsersFromEventInvitationUpdateOptions)
        {
            var returningUsersFromEventInvitationEntity = await _returningUsersFromEventInvitationEntityStore.FetchByIdAsync(guid);
            returningUsersFromEventInvitationEntity.CreatedDate = DateTime.UtcNow;
            returningUsersFromEventInvitationEntity.InvitationChannelId = returningUsersFromEventInvitationUpdateOptions.InvitationChannelId;
            returningUsersFromEventInvitationEntity.UpdatedDate = DateTime.UtcNow;
            returningUsersFromEventInvitationEntity.UserId = returningUsersFromEventInvitationUpdateOptions.UserId;
            returningUsersFromEventInvitationEntity.TrackingNumber = returningUsersFromEventInvitationUpdateOptions.TrackingNumber;


            returningUsersFromEventInvitationEntity = await _returningUsersFromEventInvitationEntityStore.UpdateByIdAsync(guid, returningUsersFromEventInvitationEntity);

            var returningUsersFromEventInvitation = new ReturningUsersFromEventInvitation(returningUsersFromEventInvitationEntity);

            return returningUsersFromEventInvitation;
        }
    }
}

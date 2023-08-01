using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public class InvitationChannelService : IInvitationChannelService
    {
        /// <summary>
        /// The invitation channel entity store
        /// </summary>
        private readonly IInvitationChannelEntityStore _invitationChannelEntityStore;


        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationChannelService"/> class.
        /// </summary>
        /// <param name="invitationChannelEntityStore">The invitation channel entity store.</param>
        public InvitationChannelService(IInvitationChannelEntityStore invitationChannelEntityStore)
        {
            _invitationChannelEntityStore = invitationChannelEntityStore;
        }


        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="invitationChannelAddOptions">The invitation channel add options.</param>
        /// <returns></returns>
        public async Task<InvitationChannel> AddAsync(InvitationChannelAddOptions invitationChannelAddOptions)
        {
            var invitationChannelEntity = new InvitationChannelEntity
            {
                CreatedDate = DateTime.Now,
                Name = invitationChannelAddOptions.Name
            };
            invitationChannelEntity = await _invitationChannelEntityStore.AddAsync(invitationChannelEntity);
            var invitationChannel = new InvitationChannel(invitationChannelEntity);

            return invitationChannel;
            
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        public async Task DeleteByIdAsync(Guid guid)
        {
            await _invitationChannelEntityStore.DeleteByIdAsync(guid);

        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<InvitationChannel> GetDetail(Guid guid)
        {
            var invitationChannelEntity = await _invitationChannelEntityStore.FetchByIdAsync(guid);
            var invitationChannel = new InvitationChannel(invitationChannelEntity);

            return invitationChannel;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<InvitationChannel>> ListAsync()
        {
            var invitationChannelEntityList = await _invitationChannelEntityStore.ListAsync();
            var invitationChannelList = invitationChannelEntityList.Select(x => new InvitationChannel(x));

            return invitationChannelList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="invitationChannelUpdateOptions">The invitation channel update options.</param>
        /// <returns></returns>
        public async Task<InvitationChannel> UpdateByIdAsync(Guid guid, InvitationChannelUpdateOptions invitationChannelUpdateOptions)
        {
            var invitationChannelEntity = await _invitationChannelEntityStore.FetchByIdAsync(guid);
            invitationChannelEntity.Name = invitationChannelUpdateOptions.Name;
            invitationChannelEntity.UpdatedDate = DateTime.UtcNow;
            invitationChannelEntity.CreatedDate = DateTime.UtcNow;

            invitationChannelEntity = await _invitationChannelEntityStore.UpdateByIdAsync(guid, invitationChannelEntity);

            var invitationChannel = new InvitationChannel(invitationChannelEntity);

            return invitationChannel;
        }
    }
}

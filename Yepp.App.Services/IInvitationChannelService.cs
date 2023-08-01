using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface IInvitationChannelService
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="invitationChannelAddOptions">The invitation channel add options.</param>
        /// <returns></returns>
        Task<InvitationChannel> AddAsync(InvitationChannelAddOptions invitationChannelAddOptions);

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="invitationChannelUpdateOptions">The invitation channel update options.</param>
        /// <returns></returns>
        Task<InvitationChannel> UpdateByIdAsync(Guid guid, InvitationChannelUpdateOptions invitationChannelUpdateOptions);

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<InvitationChannel> GetDetail(Guid guid);

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task DeleteByIdAsync(Guid guid);

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<InvitationChannel>> ListAsync();
    }
}
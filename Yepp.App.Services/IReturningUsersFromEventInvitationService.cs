using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface IReturningUsersFromEventInvitationService
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="addressAddOptions">The address add options.</param>
        /// <returns></returns>
        Task<ReturningUsersFromEventInvitation> AddAsync(ReturningUsersFromEventInvitationAddOptions returningUsersFromEventInvitationAddOptions);

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task DeleteByIdAsync(Guid guid);

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<ReturningUsersFromEventInvitation> GetDetail(Guid guid);

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ReturningUsersFromEventInvitation>> ListAsync();

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="addressUpdateOptions">The address update options.</param>
        /// <returns></returns>
        Task<ReturningUsersFromEventInvitation> UpdateByIdAsync(Guid guid, ReturningUsersFromEventInvitationUpdateOptions returningUsersFromEventInvitationUpdateOptions);
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface IEmailListService
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="emailListAddOptions">The email list add options.</param>
        /// <returns></returns>
        Task<EmailList> AddAsync(EmailListAddOptions emailListAddOptions);

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="emailListUpdateOptions">The email list update options.</param>
        /// <returns></returns>
        Task<EmailList> UpdateByIdAsync(Guid guid, EmailListUpdateOptions emailListUpdateOptions);

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task DeleteByIdAsync(Guid guid);


        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="email">The GUID.</param>
        /// <returns></returns>
        Task DeleteByEmailAsync(string email);

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<EmailList> GetDetail(Guid guid);

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<EmailList>> ListAsync();
    }
}
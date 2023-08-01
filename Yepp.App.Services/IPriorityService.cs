using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface IPriorityService
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="PriorityAddOptions">The priority add options.</param>
        /// <returns>
        /// Role
        /// </returns>
        Task<Priority> AddAsync(PriorityAddOptions PriorityAddOptions);

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task DeleteByIdAsync(Guid guid);

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns>
        /// Role List
        /// </returns>
        Task<IEnumerable<Priority>> ListAsync();

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>
        /// Role
        /// </returns>
        Task<Priority> GetDetail(Guid guid);
    }
}

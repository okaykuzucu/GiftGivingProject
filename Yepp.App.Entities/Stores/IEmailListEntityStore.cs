using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    public interface IEmailListEntityStore : IEntityStore<EmailListEntity>
    {
        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<EmailListEntity> GetDetail(Guid guid);

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="email">The GUID.</param>
        /// <returns></returns>
        Task DeleteByEmailAsync(string email);
    }
}
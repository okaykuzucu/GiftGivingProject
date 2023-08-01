using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface IRoleService 
    {
        /// <summary>Adds the asynchronous.</summary>
        /// <param name="RoleAddOptions">The Role add options.</param>
        /// <returns>
        ///   Role
        /// </returns>
        Task<Role> AddAsync(RoleAddOptions RoleAddOptions);

        /// <summary>Deletes the by identifier asynchronous.</summary>
        /// <param name="id">The unique identifier.</param>
        Task DeleteByIdAsync(Guid guid);

        /// <summary>Lists the asynchronous.</summary>
        /// <returns>
        ///   Role List
        /// </returns>
        Task<IEnumerable<Role>> ListAsync();

        /// <summary>Gets the detail.</summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>
        ///   Role
        /// </returns>
        Task<Role> GetDetail(Guid guid);
    }
}

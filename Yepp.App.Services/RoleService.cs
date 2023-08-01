using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleEntityStore _roleEntityStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleService"/> class.
        /// </summary>
        /// <param name="roleEntityStore">The role entity store.</param>
        public RoleService(IRoleEntityStore roleEntityStore)
        {
            _roleEntityStore = roleEntityStore;
        }

        /// <summary>Adds the asynchronous.</summary>
        /// <param name="roleAddOptions">The role add options.</param>
        /// <returns>
        ///   Role
        /// </returns>
        public async Task<Role> AddAsync(RoleAddOptions roleAddOptions)
        {
            var roleEntity = new RoleEntity
            {
                Name = roleAddOptions.Name
    
            };

            roleEntity = await _roleEntityStore.AddAsync(roleEntity);
            var role = new Role(roleEntity);

            return role;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid"></param>
        public async Task DeleteByIdAsync(Guid guid)
        {
            await _roleEntityStore.DeleteByIdAsync(guid);
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>
        /// Role
        /// </returns>
        public async Task<Role> GetDetail(Guid guid)
        {
            var roleEntity = await _roleEntityStore.GetDetail(guid);
            var role = new Role(roleEntity);
            return role;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns>
        /// Role List
        /// </returns>
        public async Task<IEnumerable<Role>> ListAsync()
        {
            var roleEntityList = await _roleEntityStore.ListAsync();
            var roleList = roleEntityList.Select(x => new Role(x));
           

            return roleList;
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Services;
using Yepp.App.Services.Models;

namespace Yepp.App.WebServices.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleController" /> class.
        /// </summary>
        /// <param name="roleService">The role service.</param>
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        /// <summary>
        /// Getlists this instance.
        /// </summary>
        /// <returns>
        ///   <br />
        /// </returns>
        [HttpGet]
        public async Task<IEnumerable<Role>> Getlist()
        {
            return await _roleService.ListAsync();
        }

        /// <summary>
        /// Adds the role.
        /// </summary>
        /// <param name="roleAddOptions">The role add options.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        [HttpPost]
        public async Task<Role> AddRole(RoleAddOptions roleAddOptions)
        {
            return await _roleService.AddAsync(roleAddOptions);
        }

        /// <summary>
        /// Deletes the role.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpDelete]

        public async Task DeleteRole(string id) 
        {
            var roleId = new Guid(id);
            await _roleService.DeleteByIdAsync(roleId);
        }
    }
}

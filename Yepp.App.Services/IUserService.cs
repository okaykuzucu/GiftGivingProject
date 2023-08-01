using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface IUserService
    {
        /// <summary>Adds the asynchronous.</summary>
        /// <param name="userAddOptions">The user add options.</param>
        /// <returns>
        ///   User
        /// </returns>
        Task<User> AddAsync(UserAddOptions userAddOptions);

        /// <summary>Updates the by identifier asynchronous.</summary>
        /// <param name="guid">The unique identifier.</param>
        /// <param name="userUpdateOptions">The user update options.</param>
        /// <returns>
        ///   User
        /// </returns>
        Task<User> UpdateByIdAsync(Guid guid,UserUpdateOptions userUpdateOptions);

        /// <summary>Deletes the by identifier asynchronous.</summary>
        /// <param name="guid">The unique identifier.</param>
        Task DeleteByIdAsync(Guid guid);

        /// <summary>Lists the asynchronous.</summary>
        /// <returns>
        ///   User List
        /// </returns>
        Task<IEnumerable<User>> ListAsync();

        /// <summary>Determines whether the specified email is registered.</summary>
        /// <param name="email">The email.</param>
        /// <returns>
        ///   True and False
        /// </returns>
        Task<bool> IsRegistered(string email);

        /// <summary>Gets the detail.</summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>
        ///   User
        /// </returns>
        Task<User> GetDetail(Guid guid);

        /// <summary>Gets the detail.</summary>
        /// <param name="email">The unique identifier.</param>
        /// <returns>
        ///   User
        /// </returns>
        Task<User> GetDetailByEmail(string email);

        /// <summary>
        /// Users the check password.
        /// </summary>
        /// <param name="current_password">The current password.</param>
        /// <returns></returns>
        Task<bool> UserCheckPassword(Guid userId, string current_password);

        /// <summary>
        /// Changes the user password.
        /// </summary>
        /// <param name="userEntity">The user entity.</param>
        /// <returns></returns>
        Task<User> ChangeUserPassword(Guid userId,UserUpdateOptions userUpdateOptions);

        /// <summary>
        /// Users the registered.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        Task<User> UserRegistered(string userId);

        /// <summary>
        /// Gets the detail mail.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        Task<User> GetDetailMail(string email);
    }
}

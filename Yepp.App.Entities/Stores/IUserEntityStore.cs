using System;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    /// <summary>
    /// The user entity store
    /// </summary>
    /// <seealso cref="Emos.Crypto.Entity.IEntityStore{Yepp.App.Entities.Models.UserEntity}" />
    public interface IUserEntityStore : IEntityStore<UserEntity>
    {
        /// <summary>
        /// Determines whether the specified email is registered.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        Task<bool> IsRegistered(string email);

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns></returns>
        Task<UserEntity> GetDetail(Guid guid);

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns></returns>
        Task<UserEntity> GetDetailByEmail(string email);

        /// <summary>
        /// Checks the user password.
        /// </summary>
        /// <param name="current_password">The current password.</param>
        /// <returns></returns>
        Task<bool> CheckUserPassword(Guid userId, string current_password);

        /// <summary>
        /// Changes the user password.
        /// </summary>
        /// <param name="userEntity">The user entity.</param>
        /// <returns></returns>
        Task<UserEntity> ChangeUserPassword(UserEntity userEntity);

        /// <summary>
        /// Gets the detail mail.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        Task<UserEntity> GetDetailMail(string email);
    }
}

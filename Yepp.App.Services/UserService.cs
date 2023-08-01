using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public class UserService : IUserService
    {
        private readonly IUserEntityStore _userEntityStore;
        private readonly IRoleEntityStore _roleEntityStore;


        /// <summary>Initializes a new instance of the <see cref="UserService" /> class.</summary>
        /// <param name="userEntityStore">The user entity store.</param>
        public UserService(IUserEntityStore userEntityStore,
            IRoleEntityStore roleEntityStore)
        {
            _userEntityStore = userEntityStore;
            _roleEntityStore = roleEntityStore;
        }

        /// <summary>Adds the asynchronous.</summary>
        /// <param name="userAddOptions">The user add options.</param>
        /// <returns>
        ///   User
        /// </returns>
        public async Task<User> AddAsync(UserAddOptions userAddOptions)
        {
            var userEntity = new UserEntity
            {
                CreatedDate = DateTime.Now,
                Email = userAddOptions.Email,
                RoleId =  _roleEntityStore.ListAsync().Result.FirstOrDefault().Id,
                Password = userAddOptions.Password,
                Name = userAddOptions.Name,
                SurName = userAddOptions.SurName,
                Telephone = userAddOptions.Telephone,
                Image = userAddOptions.Image,
                Language = userAddOptions.Language,
                RegistrationDate = DateTime.Now,
                IsRegistered = true,
                KvkkChecked = userAddOptions.KvkkChecked
            };
            userEntity = await _userEntityStore.AddAsync(userEntity);
            var user = new User(userEntity);

            return user;
        }

        /// <summary>
        /// Changes the user password.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userUpdateOptions"></param>
        /// <returns></returns>
        public async Task<User> ChangeUserPassword(Guid userId,UserUpdateOptions userUpdateOptions)
        {
            var userEntity = await _userEntityStore.FetchByIdAsync(userId);
            userEntity.Password = userUpdateOptions.Password;
            var _user = await _userEntityStore.ChangeUserPassword(userEntity);

            return  new User(_user);
        }

        /// <summary>Deletes the by identifier asynchronous.</summary>
        /// <param name="guid">The unique identifier.</param>
        public async Task DeleteByIdAsync(Guid guid)
        {
            await _userEntityStore.DeleteByIdAsync(guid);
        }

        /// <summary>Gets the detail.</summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>
        ///   User
        /// </returns>
        public async Task<User> GetDetail(Guid guid)
        {
            var userEntity = await _userEntityStore.GetDetail(guid);
            var user = new User(userEntity);
            
            return user;
        }

        /// <summary>Gets the detail.</summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>
        ///   User
        /// </returns>
        public async Task<User> GetDetailByEmail(string email)
        {
            var userEntity = await _userEntityStore.GetDetailByEmail(email);
            var user = new User(userEntity);

            return user;
        }

        /// <summary>
        /// Gets the detail mail.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public async Task<User> GetDetailMail(string email)
        {
            var userEntity = await _userEntityStore.GetDetailMail(email);
            var user = new User(userEntity);

            return user;
        }

        /// <summary>Determines whether the specified email is registered.</summary>
        /// <param name="email">The email.</param>
        /// <returns>
        ///   <c>true</c> if the specified email is registered; otherwise, <c>false</c>.</returns>
        public async Task<bool> IsRegistered(string email)
        {
            return await _userEntityStore.IsRegistered(email);
        }

        /// <summary>Lists the asynchronous.</summary>
        /// <returns>
        ///  User List
        /// </returns>
        public async Task<IEnumerable<User>> ListAsync()
        {
            var userEntityList = await _userEntityStore.ListAsync();
            var userList = userEntityList.Select(x => new User(x));

            return userList;
        }

        /// <summary>Updates the by identifier asynchronous.</summary>
        /// <param name="guid">The unique identifier.</param>
        /// <param name="userUpdateOptions">The user update options.</param>
        /// <returns>
        ///   User
        /// </returns>
        public async Task<User> UpdateByIdAsync(Guid guid, UserUpdateOptions userUpdateOptions)
        {
            var userEntity = await _userEntityStore.FetchByIdAsync(guid);
            userEntity.Image = userUpdateOptions.Image;
            userEntity.UpdatedDate = DateTime.Now; ;
            userEntity.Name = userUpdateOptions.Name;
            userEntity.SurName = userUpdateOptions.SurName;
            userEntity.Telephone = userUpdateOptions.Telephone;
            userEntity.Email = userUpdateOptions.Email;
            userEntity.Password = userUpdateOptions.Password;

            userEntity = await _userEntityStore.UpdateByIdAsync(guid, userEntity);

            var user = new User(userEntity);

            return user;
        }

        /// <summary>
        /// Users the check password.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="currentPassword">The current password.</param>
        /// <returns></returns>
        public async Task<bool> UserCheckPassword(Guid userId, string currentPassword)
        {
            return await _userEntityStore.CheckUserPassword(userId, currentPassword);
        }

        /// <summary>
        /// Users the registered.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        public async Task<User> UserRegistered(string userId)
        {
            var userEntity = await _userEntityStore.FetchByIdAsync(new Guid(userId));
            userEntity.IsRegistered = true;
            userEntity= await  _userEntityStore.UpdateByIdAsync(new Guid(userId), userEntity);
          
            return new User(userEntity);
        }
    }
}

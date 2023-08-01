using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    /// <summary>
    /// User entity store
    /// </summary>
    /// <seealso cref="Yepp.App.Entities.BaseEntityStore" />
    /// <seealso cref="Yepp.App.Entities.Stores.IUserEntityStore" />
    public class UserEntityStore : BaseEntityStore, IUserEntityStore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEntityStore"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public UserEntityStore(EntitiesDbContext dbContext)
            : base(dbContext)
        {
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<UserEntity> AddAsync(UserEntity document)
        {
            await _dbContext.Users.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            var userEntity =
               await _dbContext.Users.FindAsync(id);

            if (userEntity != null)
            {
                _dbContext.Users.Remove(userEntity);

                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<UserEntity> FetchByIdAsync(Guid id)
        {
            var userEntity =
                await _dbContext.Users.FindAsync(id);

            
            return userEntity;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<UserEntity>> ListAsync()
        {
            var userEntityList =
            await _dbContext.Users.ToListAsync();

            return userEntityList;
        }

        /// <summary>Updates the by identifier asynchronous.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns>
        ///   User Entity
        /// </returns>
        public async Task<UserEntity> UpdateByIdAsync(Guid id, UserEntity document)
        {
            var userEntityToUpdate =
            await _dbContext.Users.FindAsync(id);

            userEntityToUpdate.Name = document.Name ?? userEntityToUpdate.Name;
            userEntityToUpdate.Image = document.Image ?? userEntityToUpdate.Image;
            userEntityToUpdate.SurName = document.SurName ?? userEntityToUpdate.SurName;
            userEntityToUpdate.Telephone = document.Telephone ?? userEntityToUpdate.Telephone;
            userEntityToUpdate.Email = document.Email ?? userEntityToUpdate.Email;
            userEntityToUpdate.UpdatedDate = DateTime.UtcNow;

           
            try
            {

                await Task.Run(() => _dbContext.Users.Update(userEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }

            return userEntityToUpdate;
        }


        /// <summary>
        /// Determines whether the specified user email is registered.
        /// </summary>
        /// <param name="userEmail">The user email.</param>
        /// <returns></returns>
        public async Task<bool> IsRegistered(string userEmail)
        {
            using (var userCheck = _dbContext.Users.AnyAsync(x => x.Email == userEmail))
            {
                if (userCheck.Result)
                {
                    return true;
                }

                return false;

            }
           
        }

        /// <summary>Gets the detail.</summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public async Task<UserEntity> GetDetail(Guid guid)
        {
            var userEntity = await _dbContext.Users.Where(x => x.Id == guid).FirstOrDefaultAsync();

            return userEntity;
        }


        /// <summary>Gets the detail.</summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public async Task<UserEntity> GetDetailByEmail(string email)
        {
            var userEntity = await _dbContext.Users.Where(x => x.Email == email).FirstOrDefaultAsync();

            return userEntity;
        }

        /// <summary>
        /// Checks the user password.
        /// </summary>
        /// <param name="currentPassword">The current password.</param>
        /// <returns></returns>
        public async Task<bool> CheckUserPassword(Guid userId, string currentPassword)
        {
            var userEntity =
            await _dbContext.Users.FindAsync(userId);

            if(userEntity.Password == currentPassword)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Changes the user password.
        /// </summary>
        /// <param name="userEntity">The user entity.</param>
        /// <returns></returns>
        public async Task<UserEntity> ChangeUserPassword(UserEntity userEntity)
        {
            var userEntityToUpdate =
            await _dbContext.Users.FindAsync(userEntity.Id);
            userEntityToUpdate.Password = userEntity.Password;

            try
            {

                await Task.Run(() => _dbContext.Users.Update(userEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }

            return userEntityToUpdate;
        }

        /// <summary>
        /// Gets the detail mail.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public async Task<UserEntity> GetDetailMail(string email)
        {
            var userEntity = await _dbContext.Users.Where(x => x.Email == email).FirstOrDefaultAsync();

            return userEntity;
        }
    }
}

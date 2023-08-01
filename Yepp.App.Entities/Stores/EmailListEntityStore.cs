using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    public class EmailListEntityStore : BaseEntityStore, IEmailListEntityStore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EMailListEntityStore"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public EmailListEntityStore(EntitiesDbContext dbContext)
            : base(dbContext)
        {

        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<EmailListEntity> AddAsync(EmailListEntity document)
        {
            await _dbContext.EmailList.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;
        }


        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="email">The identifier.</param>
        public async Task DeleteByEmailAsync(string email)
        {
            var emailListEntity = _dbContext.EmailList.Where(x => x.Email == email);

            if (emailListEntity != null)
            {
                _dbContext.EmailList.RemoveRange(emailListEntity);

                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            var emailListEntity =
                await _dbContext.EmailList.FindAsync(id);

            if (emailListEntity != null)
            {
                _dbContext.EmailList.Remove(emailListEntity);

                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<EmailListEntity> FetchByIdAsync(Guid id)
        {
            var emailListEntity =
                await _dbContext.EmailList.FindAsync(id);

            return emailListEntity;
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<EmailListEntity> GetDetail(Guid guid)
        {
            var emailListEntity = await _dbContext.EmailList.Where(x => x.Id == guid).FirstOrDefaultAsync();

            return emailListEntity;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EmailListEntity>> ListAsync()
        {
            var emailListEntityList =
                await _dbContext.EmailList.ToListAsync();

            return emailListEntityList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<EmailListEntity> UpdateByIdAsync(Guid id, EmailListEntity document)
        {
            var emailListEntityToUpdate =
                await _dbContext.EmailList.FindAsync(id);
            emailListEntityToUpdate.CreatedDate = document.CreatedDate;
            emailListEntityToUpdate.Email = emailListEntityToUpdate.Email;
            emailListEntityToUpdate.Id = emailListEntityToUpdate.Id;
            await _dbContext.SaveChangesAsync();

            try
            {
                await Task.Run(() => _dbContext.EmailList.Update(emailListEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }
            return emailListEntityToUpdate;
        }
    }
}

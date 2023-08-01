using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public class EmailListService : IEmailListService
    {
        /// <summary>
        /// The email list entity store
        /// </summary>
        private readonly IEmailListEntityStore _emailListEntityStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailListService"/> class.
        /// </summary>
        /// <param name="emailListEntityStore">The email list entity store.</param>
        public EmailListService(IEmailListEntityStore emailListEntityStore)
        {
            _emailListEntityStore = emailListEntityStore;
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="emailListAddOptions">The email list add options.</param>
        /// <returns></returns>
        public async Task<EmailList> AddAsync(EmailListAddOptions emailListAddOptions)
        {
            var emailListEntity = new EmailListEntity
            {
                Email = emailListAddOptions.Email,
                CreatedDate = DateTime.UtcNow,
            };
            emailListEntity = await _emailListEntityStore.AddAsync(emailListEntity);

            var emailList = new EmailList(emailListEntity);

            return emailList;
        }

        // <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="email">The identifier.</param>
        public async Task DeleteByEmailAsync(string email)
        {
            await _emailListEntityStore.DeleteByEmailAsync(email);
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            await _emailListEntityStore.DeleteByIdAsync(id);
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<EmailList> GetDetail(Guid guid)
        {
            var emailListEntity = await _emailListEntityStore.GetDetail(guid);
            var emailList = new EmailList(emailListEntity);

            return emailList;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EmailList>> ListAsync()
        {
            var emailListEntityList = await _emailListEntityStore.ListAsync();
            var emailListList = emailListEntityList.Select(x => new EmailList(x));

            return emailListList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="emailListUpdateOptions">The email list update options.</param>
        /// <returns></returns>
        public async Task<EmailList> UpdateByIdAsync(Guid guid, EmailListUpdateOptions emailListUpdateOptions)
        {
            var emailListEntity = await _emailListEntityStore.FetchByIdAsync(guid);
            emailListEntity.CreatedDate = emailListUpdateOptions.CreatedDate;
            emailListEntity.Email = emailListUpdateOptions.Email;

            emailListEntity = await _emailListEntityStore.UpdateByIdAsync(guid, emailListEntity);

            var emailList = new EmailList(emailListEntity);

            return emailList;
        }
    }
}

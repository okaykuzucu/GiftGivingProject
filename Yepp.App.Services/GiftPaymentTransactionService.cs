using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public class GiftPaymentTransactionService : IGiftPaymentTransactionService
    {
        private readonly IGiftPaymentTransactionEntityStore _giftPaymentTransactionEntityStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="GiftPaymentTransactionService"/> class.
        /// </summary>
        /// <param name="giftPaymentTransactionEntityStore">The gift payment transaction entity store.</param>
        public GiftPaymentTransactionService(IGiftPaymentTransactionEntityStore giftPaymentTransactionEntityStore)
        {
            _giftPaymentTransactionEntityStore = giftPaymentTransactionEntityStore;
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="giftPaymentTransactionAddOptions"></param>
        /// <returns></returns>
        public async Task<GiftPaymentTransaction> AddAsync(GiftPaymentTransactionAddOptions giftPaymentTransactionAddOptions)
        {
            var giftPaymentTransactionEntity = new GiftPaymentTransactionEntity
            {
                ActualPrice = giftPaymentTransactionAddOptions.ActualPrice,
                CreatedDate = giftPaymentTransactionAddOptions.CreatedDate,
                GiftId = giftPaymentTransactionAddOptions.GiftId,
                UpdatedDate = giftPaymentTransactionAddOptions.UpdatedDate,
                UserId = giftPaymentTransactionAddOptions.UserId  
            };
            giftPaymentTransactionEntity = await _giftPaymentTransactionEntityStore.AddAsync(giftPaymentTransactionEntity);

            var giftPaymentTransaction = new GiftPaymentTransaction(giftPaymentTransactionEntity);

            return giftPaymentTransaction;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        public async Task DeleteByIdAsync(Guid guid)
        {
            await _giftPaymentTransactionEntityStore.DeleteByIdAsync(guid);
        }

        /// <summary>
        /// Gets the detail by gift identifier.
        /// </summary>
        /// <param name="giftId">The gift identifier.</param>
        /// <returns></returns>
        public async Task<GiftPaymentTransaction> GetDetailByGiftId(Guid giftId)
        {
            var giftPaymentTransactionEntity = await _giftPaymentTransactionEntityStore.GetDetailByGiftId(giftId);
            var giftPaymentTransaction = new GiftPaymentTransaction(giftPaymentTransactionEntity);

            return giftPaymentTransaction;
        }

        /// <summary>
        /// Gets the detail by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<GiftPaymentTransaction> GetDetailById(Guid id)
        {
            var giftPaymentTransactionEntity = await _giftPaymentTransactionEntityStore.GetDetailById(id);
            var giftPaymentTransaction = new GiftPaymentTransaction(giftPaymentTransactionEntity);

            return giftPaymentTransaction;
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<GiftPaymentTransaction> GetDetail(Guid guid)
        {
            var giftPaymentTransactionEntity = await _giftPaymentTransactionEntityStore.GetDetail(guid);
            var giftPaymentTransaction = new GiftPaymentTransaction(giftPaymentTransactionEntity);
            return giftPaymentTransaction;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<GiftPaymentTransaction>> ListAsync()
        {
            var giftPaymentTransactionEntityList = await _giftPaymentTransactionEntityStore.ListAsync();
            var giftPaymentTransactionList = giftPaymentTransactionEntityList.Select(x => new GiftPaymentTransaction(x));

            return giftPaymentTransactionList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="giftPaymentTransactionUpdateOptions"></param>
        /// <returns></returns>
        public async Task<GiftPaymentTransaction> UpdateByIdAsync(Guid guid, GiftPaymentTransactionUpdateOptions giftPaymentTransactionUpdateOptions)
        {
            var giftPaymentTransactionEntity = await _giftPaymentTransactionEntityStore.FetchByIdAsync(guid);
            {
                giftPaymentTransactionEntity.ActualPrice = giftPaymentTransactionUpdateOptions.ActualPrice;
                giftPaymentTransactionEntity.CreatedDate = DateTime.UtcNow;
                giftPaymentTransactionEntity.GiftId = giftPaymentTransactionUpdateOptions.GiftId;
                giftPaymentTransactionEntity.UpdatedDate = DateTime.UtcNow;
                giftPaymentTransactionEntity.UserId = giftPaymentTransactionUpdateOptions.UserId;
            }


            giftPaymentTransactionEntity = await _giftPaymentTransactionEntityStore.UpdateByIdAsync(guid, giftPaymentTransactionEntity);

            var giftPaymentTransaction = new GiftPaymentTransaction(giftPaymentTransactionEntity);

            return giftPaymentTransaction;
        }
    }
}

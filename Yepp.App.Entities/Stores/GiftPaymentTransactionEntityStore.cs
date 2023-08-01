using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    public class GiftPaymentTransactionEntityStore : BaseEntityStore, IGiftPaymentTransactionEntityStore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GiftPaymentTransactionEntityStore"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public GiftPaymentTransactionEntityStore(EntitiesDbContext dbContext)
        : base(dbContext)
        {
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<GiftPaymentTransactionEntity> AddAsync(GiftPaymentTransactionEntity document)
        {
            await _dbContext.GiftPaymentTransactions.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            var giftPaymentTransactionEntity =
               await _dbContext.GiftPaymentTransactions.FindAsync(id);
            if (giftPaymentTransactionEntity != null)
            {
                _dbContext.GiftPaymentTransactions.Remove(giftPaymentTransactionEntity);

                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<GiftPaymentTransactionEntity> FetchByIdAsync(Guid id)
        {
            var giftPaymentTransactionEntity =
            await _dbContext.GiftPaymentTransactions.FindAsync(id);

            return giftPaymentTransactionEntity;
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="giftPaymentTransactionId">The gift payment transaction identifier.</param>
        /// <returns></returns>
        public async Task<GiftPaymentTransactionEntity> GetDetail(Guid giftPaymentTransactionId)
        {
            var giftPaymentTransactionEntity = await _dbContext.GiftPaymentTransactions.Where(x => x.Id == giftPaymentTransactionId).FirstOrDefaultAsync();

            return giftPaymentTransactionEntity;
        }

        /// <summary>
        /// Gets the detail by gift identifier.
        /// </summary>
        /// <param name="giftId">The gift identifier.</param>
        /// <returns></returns>
        public async Task<GiftPaymentTransactionEntity> GetDetailByGiftId(Guid giftId)
        {
            var giftPaymentTransactionEntity = await _dbContext.GiftPaymentTransactions.Where(x => x.GiftId == giftId).FirstOrDefaultAsync();

            return giftPaymentTransactionEntity;
        }

        /// <summary>
        /// Gets the detail by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<GiftPaymentTransactionEntity> GetDetailById(Guid id)
        {
            var giftPaymentTransactionEntity = await _dbContext.GiftPaymentTransactions.Where(x => x.Id == id).FirstOrDefaultAsync();

            return giftPaymentTransactionEntity;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<GiftPaymentTransactionEntity>> ListAsync()
        {
            var giftPaymentTransactionEntityList = await _dbContext.GiftPaymentTransactions.ToListAsync();

            return giftPaymentTransactionEntityList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<GiftPaymentTransactionEntity> UpdateByIdAsync(Guid id, GiftPaymentTransactionEntity document)
        {
            var giftPaymentTransactionEntityToUpdate =
            await _dbContext.GiftPaymentTransactions.FindAsync(id);
            giftPaymentTransactionEntityToUpdate.ActualPrice = document.ActualPrice;
            giftPaymentTransactionEntityToUpdate.CreatedDate = DateTime.UtcNow;
            giftPaymentTransactionEntityToUpdate.GiftId = document.GiftId;
            giftPaymentTransactionEntityToUpdate.Id = document.Id;
            giftPaymentTransactionEntityToUpdate.UpdatedDate = DateTime.UtcNow;
            giftPaymentTransactionEntityToUpdate.UserId = document.UserId;

            try
            {

                await Task.Run(() => _dbContext.GiftPaymentTransactions.Update(giftPaymentTransactionEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }


            return giftPaymentTransactionEntityToUpdate;
        }
    }
}

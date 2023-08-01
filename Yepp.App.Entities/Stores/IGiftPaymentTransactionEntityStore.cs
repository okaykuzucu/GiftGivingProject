using System;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    public interface IGiftPaymentTransactionEntityStore : IEntityStore<GiftPaymentTransactionEntity>
    {
        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<GiftPaymentTransactionEntity> GetDetail(Guid guid);

        /// <summary>
        /// Gets the detail by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<GiftPaymentTransactionEntity> GetDetailById(Guid id);

        /// <summary>
        /// Gets the detail by gift identifier.
        /// </summary>
        /// <param name="giftId">The gift identifier.</param>
        /// <returns></returns>
        Task<GiftPaymentTransactionEntity> GetDetailByGiftId(Guid giftId);
    }
}

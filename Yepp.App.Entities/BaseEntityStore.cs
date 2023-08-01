using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Entities
{
    /// <summary>
    /// Base entity store
    /// </summary>
    public abstract class BaseEntityStore
    {
        protected readonly EntitiesDbContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseEntityStore"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public BaseEntityStore(
            EntitiesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}

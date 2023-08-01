using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities
{
    /// <summary>
    /// Base entity
    /// </summary>
    /// <seealso cref="Yepp.App.Entities.IEntity" />
    public abstract class BaseEntity : IEntity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Column("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseEntity"/> class.
        /// </summary>
        public BaseEntity()
        {
            this.Id = Guid.NewGuid();
        }
    }
}

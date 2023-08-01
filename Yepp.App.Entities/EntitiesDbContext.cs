using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities
{
    public class EntitiesDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesDbContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public EntitiesDbContext(DbContextOptions<EntitiesDbContext> options)
            : base(options)
        {
            //performans
            this.ChangeTracker.LazyLoadingEnabled = false;
            this.ChangeTracker.AutoDetectChangesEnabled = false;
        }
        /// <summary>
        /// Called when [model creating].
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<GameInfoEntity>(entity =>
            {
                entity.Property(e => e.GameScore).HasColumnType("numeric(18, 3)");
            }); ;
        }

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>
        /// The users.
        /// </value>
        public DbSet<UserEntity> Users { get; set; }

        /// <summary>Gets or sets the addresses.</summary>
        /// <value>The addresses.</value>
        public DbSet<AddressEntity> Addresses { get; set; }

        /// <summary>Gets or sets the addresses types.</summary>
        /// <value>The addresses types.</value>
        public DbSet<AddressTypeEntity> AddressesTypes { get; set; }

        /// <summary>Gets or sets the categories.</summary>
        /// <value>The categories.</value>
        public DbSet<CategoryEntity> Categories { get; set; }

        /// <summary>Gets or sets the cities.</summary>
        /// <value>The cities.</value>
        public DbSet<CityEntity> Cities { get; set; }

        /// <summary>Gets or sets the countries.</summary>
        /// <value>The countries.</value>
        public DbSet<CountryEntity> Countries { get; set; }

        /// <summary>Gets or sets the events.</summary>
        /// <value>The events.</value>
        public DbSet<EventEntity> Events { get; set; }

        /// <summary>Gets or sets the event invitations.</summary>
        /// <value>The event invitations.</value>
        public DbSet<EventInvitationEntity> EventInvitations { get; set; }

        /// <summary>Gets or sets the event notifcations.</summary>
        /// <value>The event notifcations.</value>
        public DbSet<EventNotificationEntity> EventNotifcations { get; set; }

        /// <summary>Gets or sets the gifts.</summary>
        /// <value>The gifts.</value>
        public DbSet<GiftEntity> Gifts { get; set; }

        /// <summary>Gets or sets the invitation channels.</summary>
        /// <value>The invitation channels.</value>
        public DbSet<InvitationChannelEntity> InvitationChannels { get; set; }

        /// <summary>Gets or sets the priorities.</summary>
        /// <value>The priorities.</value>
        public DbSet<PriorityEntity> Priorities { get; set; }

        /// <summary>Gets or sets the purchased gifts.</summary>
        /// <value>The purchased gifts.</value>
        public DbSet<PurchasedGiftEntity> PurchasedGifts{ get; set; }

        /// <summary>Gets or sets the purchases.</summary>
        /// <value>The purchases.</value>
        public DbSet<PurchaseEntity> Purchases { get; set; }

        /// <summary>Gets or sets the roles.</summary>
        /// <value>The roles.</value>
        public DbSet<RoleEntity> Roles { get; set; }

        /// <summary>Gets or sets the ships.</summary>
        /// <value>The ships.</value>
        public DbSet<ShipEntity> Ships { get; set; }

        /// <summary>Gets or sets the shippers.</summary>
        /// <value>The shippers.</value>
        public DbSet<ShipperEntity> Shippers { get; set; }

        /// <summary>Gets or sets the status.</summary>
        /// <value>The status.</value>
        public DbSet<EventStatusEntity> Event_Status { get; set; }

        /// <summary>
        /// Gets or sets the game infos.
        /// </summary>
        /// <value>
        /// The game infos.
        /// </value>
        public DbSet<GameInfoEntity> GameInfos { get; set; }

        /// <summary>
        /// Gets or sets the event notification statuses.
        /// </summary>
        /// <value>
        /// The event notification statuses.
        /// </value>
        public DbSet<EventNotificationStatusEntity> EventNotificationStatuses { get; set; }

        /// <summary>
        /// Gets or sets the returning users from event invitations.
        /// </summary>
        /// <value>
        /// The returning users from event invitations.
        /// </value>
        public DbSet<ReturningUsersFromEventInvitationEntity> ReturningUsersFromEventInvitations { get; set; }

        /// <summary>
        /// Gets or sets the gift payment transactions.
        /// </summary>
        /// <value>
        /// The gift payment transactions.
        /// </value>
        public DbSet<GiftPaymentTransactionEntity> GiftPaymentTransactions { get; set; }

        /// <summary>
        /// Gets or sets the accepted marketplaces.
        /// </summary>
        /// <value>
        /// The accepted marketplaces.
        /// </value>
        public DbSet<AcceptedMarketplacesEntity> AcceptedMarketplaces { get; set; }

        /// <summary>
        /// Gets or sets the email list.
        /// </summary>
        /// <value>
        /// The email list.
        /// </value>
        public DbSet<EmailListEntity> EmailList { get; set; }

    }
}

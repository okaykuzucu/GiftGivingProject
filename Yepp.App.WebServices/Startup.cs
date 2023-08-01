using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Yepp.App.Bussines.Securities;
using Yepp.App.Entities;
using Yepp.App.Entities.Stores;
using Yepp.App.Services;
using System.Net.Http.Headers;

namespace Yepp.App.WebServices
{
    /// <summary>
    /// The yepp api startup project file
    /// </summary>
    public class Startup
    {
        private readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Configures the services.
        /// </summary>
        /// <param name="services">The services.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            #region IdentityServer4

            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
                        .AddIdentityServerAuthentication(options =>
                                {
                                    options.Authority = "http://yepp-id.azurewebsites.net";
                                    options.ApiName = "service-one";
                                    options.RequireHttpsMetadata = false;
                                });

            #endregion IdentityServer4

            if (Configuration["DB:SQLServer:Use"] == "True")
            {
                var connectionStringPlaceHolder = Configuration["DB:SQLServer:ConnectionString"];
                services.AddDbContextPool<EntitiesDbContext>(
                    options =>
                    SqlServerDbContextOptionsExtensions.UseSqlServer(options, connectionStringPlaceHolder.Replace("{dbName}", "test")));
            }

            if (Configuration["DB:PostgreSQL:Use"] == "True")
            {
                services.AddDbContext<EntitiesDbContext>((serviceProvider, dbContextBuilder) =>
                {
                    var connectionStringPlaceHolder = Configuration["DB:PostgreSQL:ConnectionString"];
                    var connectionString = connectionStringPlaceHolder.Replace("{dbName}", "test");
                    dbContextBuilder.UseNpgsql(connectionString);
                });
            }

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserEntityStore, UserEntityStore>();
            services.AddScoped<IRoleService, RoleService>();

            services.AddScoped<IRoleEntityStore, RoleEntityStore>();
            services.AddScoped<IDataSecurity, DataSecurity>();

            services.AddScoped<IAddressTypeService, AddressTypeService>();
            services.AddScoped<IAddressTypeEntityStore, AddresTypeEntityStore>();

            services.AddScoped<IGiftPaymentTransactionService, GiftPaymentTransactionService>();
            services.AddScoped<IGiftPaymentTransactionEntityStore, GiftPaymentTransactionEntityStore>();

            services.AddScoped<ICityService, CityService>();
            services.AddScoped<ICityEntityStore, CityEntityStore>();

            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ICountryEntityStore, CountryEntityStore>();

            services.AddScoped<IGameInfoEntityStore, GameInfoEntityStore>();
            services.AddScoped<IGameInfoService, GameInfoService>();

            services.AddScoped<IInvitationChannelEntityStore, InvitationChannelEntityStore>();
            services.AddScoped<IInvitationChannelService, InvitationChannelService>();

            services.AddScoped<IEventEntityStore, EventEntityStore>();
            services.AddScoped<IEventService, EventService>();

            services.AddScoped<IPriorityEntityStore, PriorityEntityStore>();
            services.AddScoped<IPriorityService, PriorityService>();

            services.AddScoped<IGiftEntityStore, GiftEntityStore>();
            services.AddScoped<IGiftService, GiftService>();

            services.AddScoped<IEventNotificationEntityStore, EventNotificationEntityStore>();
            services.AddScoped<IEventNotificationService, EventNotificationService>();

            services.AddScoped<IEventInvitationEntityStore, EventInvitationEntityStore>();
            services.AddScoped<IEventInvitationService, EventInvitationService>();

            services.AddScoped<ICategoryEntityStore, CategoryEntityStore>();
            services.AddScoped<ICategoryService, CategoryService>();

            services.AddScoped<IReturningUsersFromEventInvitationEntityStore, ReturningUsersFromEventInvitationEntityStore>();
            services.AddScoped<IReturningUsersFromEventInvitationService, ReturningUsersFromEventInvitationService>();

            services.AddScoped<IEventStatusEntityStore, EventStatusEntityStore>();
            services.AddScoped<IEventStatusService, EventStatusService>();

            services.AddScoped<IAcceptedMarketplacesEntityStore, AcceptedMarketplacesEntityStore>();
            services.AddScoped<IAcceptedMarketplacesService, AcceptedMarketplacesServices>();

            services.AddScoped<IEmailListEntityStore, EmailListEntityStore>();
            services.AddScoped<IEmailListService, EmailListService>();

            services.AddHttpClient("yepp-mandrill-api", configureClient =>
            {
                configureClient.BaseAddress = new Uri(Configuration["Mandrill:BaseAddress"].ToString());
                configureClient
                    .DefaultRequestHeaders
                    .Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            });

            services.AddHttpClient("paymes-auth-api", configureClient =>
            {
                configureClient.BaseAddress = new Uri(Configuration["Paymes:BaseAddress"].ToString());
                configureClient
                    .DefaultRequestHeaders
                    .Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            });

            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });

            services.AddControllers();
        }

        /// <summary>
        /// Configures the specified application.
        /// </summary>
        /// <param name="app">The application.</param>
        /// <param name="env">The env.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            #region IdentityServer4

            app.UseAuthentication();

            #endregion IdentityServer4

            app.UseCors(MyAllowSpecificOrigins);
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
using System.Text.Json.Serialization;

namespace Yepp.App.Services.Models
{
    public class ActivityRelatesEmail
    {
        /// <summary>
        /// Gets or sets a value indicating whether [you have new notifications].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [you have new notifications]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("youHaveNewNotifications")]
        public bool YouHaveNewNotifications { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [you are sent a direct message].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [you are sent a direct message]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("youAreSentADirectMessage")]
        public bool YouAreSentADirectMessage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [someone adds you as as a connection].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [someone adds you as as a connection]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("someoneAddsYouAsAsAConnection")]
        public bool SomeoneAddsYouAsAsAConnection { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [upon new order].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [upon new order]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("uponNewOrder")]
        public bool UponNewOrder { get; set; }

        /// <summary>
        /// Creates new membershipapproval.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [new membership approval]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("newMembershipApproval")]
        public bool NewMembershipApproval { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [member registration].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [member registration]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("memberRegistration")]
        public bool MemberRegistration { get; set; }
    }
}

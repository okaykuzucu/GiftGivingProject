namespace Yepp.App.WebServices.Dtos
{
    /// <summary>
    /// The Forgot my Password
    /// </summary>
    public class ChangePasswordDto
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the current password.
        /// </summary>
        /// <value>
        /// The current password.
        /// </value>
        public string CurrentPassword { get; set; }

        /// <summary>
        /// Creates new password.
        /// </summary>
        /// <value>
        /// The new password.
        /// </value>
        public string NewPassword { get; set; }

        /// <summary>
        /// Gets or sets the check new password.
        /// </summary>
        /// <value>
        /// The check new password.
        /// </value>
        public string CheckNewPassword { get; set; }

    }
}

namespace Yepp.App.Mandrill.Services.Models.Enums
{
    /// <summary>
    /// The Mandrill for Http Status Codes
    /// </summary>
    public enum MandrillError
    {
        /// <summary>
        /// The ok
        /// </summary>
        OK,

        /// <summary>
        /// The web exception
        /// </summary>
        WebException,

        /// <summary>
        /// The HTTP not ok
        /// </summary>
        HttpNotOk,

        /// <summary>
        /// The invalid
        /// </summary>
        Invalid,

        /// <summary>
        /// The rejected
        /// </summary>
        Rejected,

        /// <summary>
        /// The unknown
        /// </summary>
        Unknown
    }
}
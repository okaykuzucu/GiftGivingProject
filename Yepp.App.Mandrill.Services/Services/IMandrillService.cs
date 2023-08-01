using System.Threading.Tasks;
using Yepp.App.Mandrill.Services.Models;
using Yepp.App.Mandrill.Services.Models.Enums;

namespace Yepp.App.Mandrill.Services.Services
{
    /// <summary>
    /// Mandrill Service of the Interface
    /// </summary>
    public interface IMandrillService
    {
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <returns>true or false</returns>
        Task<MandrillError> SendMessage(dynamic parameters);

        /// <summary>
        /// Emails the activation.
        /// </summary>
        /// <returns>true or false</returns>
        Task<MandrillResult> EmailActivation();

        /// <summary>
        /// Games the information email information.
        /// </summary>
        /// <returns></returns>
        Task GameInfoEmailInformation();

        /// <summary>
        /// Payments the information email information.
        /// </summary>
        /// <returns></returns>
        Task PaymesInfoEmailInformation();

    }
}

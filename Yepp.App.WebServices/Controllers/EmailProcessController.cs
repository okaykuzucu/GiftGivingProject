using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Yepp.App.WebServices.Controllers
{

    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EmailProcessController : ControllerBase
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailProcessController"/> class.
        /// </summary>
        public EmailProcessController()
        {
        }

        /// <summary>
        /// Emails the activation.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> EmailActivation()
        {
            return Ok(); 
        }
    }
}

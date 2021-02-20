using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWebApi.Controllers
{
    [Route("wallet")]
    [ApiController]
    public class WalletCollectionsController : Controller
    {
        [HttpGet("collections/{address}")]
        public ActionResult<IEnumerable<string>> Get(string address)
        {
            return new string[] { "1", "3", "4", "11", "21" };
        }
    }
}

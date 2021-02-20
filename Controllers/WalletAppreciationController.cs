using GalleryWebApi.Domain.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWebApi.Controllers
{
    [Route("wallet")]
    [ApiController]
    public class WalletAppreciationController : Controller
    {
        [HttpGet("appreciation/{address}")]
        public ActionResult<IEnumerable<Appreciation>> Get(string address)
        {
            return new List<Appreciation> 
            { new Appreciation
                {
                    CollectionId = "1",
                    TokenId = "1",
                    CreatedDate = DateTime.Now,
                    Appreciator = "sdfwsdfsdf",
                    Artist = "123123sdfwsdfsdf",
                    Amount = "23423423423423",
                    IpfsUrl = "23423423423"
                } 
            };
        }
    }
}

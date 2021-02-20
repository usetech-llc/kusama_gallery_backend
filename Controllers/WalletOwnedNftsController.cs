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
    public class WalletOwnedNftsController : Controller
    {
        [HttpGet("ownedNfts/{address}")]
        public ActionResult<IEnumerable<Token>> Get(string address)
        {
            List<Token> tokens = new List<Token>();
            for (var i = 1; i < 10; i++)
            {
                tokens.Add(new Token
                {
                    CollectionId = $"{i << 3}",
                    TokenId = $"{i}",
                    Creator = "B213123123",
                    OwnerAddress = "B213123123",
                    CreatedDate = DateTime.Now,
                    Metadata = "null",
                    Status = "Display",
                    ReportReason = "None"
                });
            }

            return tokens;
        }
    }
}

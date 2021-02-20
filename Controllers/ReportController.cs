using GalleryWebApi.Domain.DTO;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReportController : Controller
    {

        private readonly NpgsqlConnection _db;

        public ReportController(NpgsqlConnection db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Token>> Get(string reportStatus)
        {
            if (reportStatus != null)
            {
                return new List<Token>
                {
                    new Token
                    {
                        CollectionId = $"{1}",
                        TokenId = $"{1}",
                        Creator = "B213123123",
                        OwnerAddress = "B213123123",
                        CreatedDate = DateTime.Now,
                        Metadata = "null",
                        Status = "Display",
                        ReportReason = "None"
                    }
                };
            }

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

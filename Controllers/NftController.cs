using GalleryWebApi.Domain.DTO;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NftController : Controller
    {

        private readonly NpgsqlConnection _db;

        public NftController(NpgsqlConnection db)
        {
            _db = db;
        }

        [HttpGet("{collectionId}/{tokenId}")]
        public ActionResult<Token> Get(string collectionId, string tokenId)
        {
            var query = $"SELECT * FROM public.ormlnfttokens WHERE key='{{{collectionId.ToString()}}}' and key2='{{{tokenId.ToString()}}}'";
            _db.Open();

            var com = _db.CreateCommand();
            com.CommandText = query;
            var reader = com.ExecuteReader();

            var dt = new DataTable();
            dt.Load(reader);
            var dataList = dt.Select().ToList();
            int index = 0;

            var result = new List<List<object>>();

            if (dataList.Count > 0)
            {
                do
                {
                    var row = new List<object>();

                    var itm = dataList.ElementAt(index).ItemArray;

                    for (var i = 0; i < itm.Count(); i++)
                    {
                        object rowValue;
                        rowValue = itm.ElementAt(i);
                        row.Add(rowValue);
                    }

                    result.Add(row);
                    index++;
                }
                while (index < dataList.Count);
            }

            _db.Close();

            return new Token
            {
                CollectionId = ((string[])result[0][1])[0].ToString(),
                TokenId = ((string[])result[0][2])[0].ToString(),
                Creator = ((string[])result[0][4])[0].ToString(),
                OwnerAddress = ((string[])result[0][4])[0].ToString(),
                CreatedDate = DateTime.Now,
                Metadata = result[0][5].ToString(),
                Status = "Display",
                ReportReason = "None"
            };
        }
    }
}

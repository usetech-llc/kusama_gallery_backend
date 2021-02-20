using GalleryWebApi.Domain.DTO;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace kusama_gallery_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DisplayController : Controller
    {
        private readonly NpgsqlConnection _db;

        public DisplayController(NpgsqlConnection db)
        {
            _db = db;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Token>> Get()
        {
            var query = "SELECT * FROM public.ormlnfttokens";
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

            List<Token> tokens = new List<Token>();
            foreach (var i in result)
            {
                tokens.Add(new Token
                {
                    CollectionId = ((string[]) i[1])[0].ToString(),
                    TokenId = ((string[])i[2])[0].ToString(),
                    Creator = ((string[])i[4])[0].ToString(),
                    OwnerAddress = ((string[])i[4])[0].ToString(),
                    CreatedDate = DateTime.Now,
                    Metadata = i[5].ToString(),
                    Status = "Display",
                    ReportReason = "None"
                });
            }

            return tokens;
        }
    }
}

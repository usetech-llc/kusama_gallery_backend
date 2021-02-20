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
    public class OffersController : Controller
    {
        private readonly NpgsqlConnection _db;

        public OffersController(NpgsqlConnection db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Offer>> Get(string address)
        {

            //var query = "SELECT * FROM public.ormlnfttokens";
            //_db.Open();

            //var com = _db.CreateCommand();
            //com.CommandText = query;
            //var reader = com.ExecuteReader();

            //var dt = new DataTable();
            //dt.Load(reader);
            //var dataList = dt.Select().ToList();
            //int index = 0;

            //var result = new List<List<object>>();

            //if (dataList.Count > 0)
            //{
            //    do
            //    {
            //        var row = new List<object>();

            //        var itm = dataList.ElementAt(index).ItemArray;

            //        for (var i = 0; i < itm.Count(); i++)
            //        {
            //            object rowValue;
            //            rowValue = itm.ElementAt(i);
            //            row.Add(rowValue);
            //        }

            //        result.Add(row);
            //        index++;
            //    }
            //    while (index < dataList.Count);
            //}

            //_db.Close();

            if (address != null)
            {
                return new List<Offer>
                {
                    new Offer
                    {
                        CollectionId = $"{1}",
                        TokenId = $"{1}",
                        CreatedDate = DateTime.Now,
                        BuyerAddress = "B213123123",
                        SellerAddress = "S213123123",
                        Price = $"{1}",
                        OfferStatus = "Completed"
                    }
                };
            }

            List<Offer> tokens = new List<Offer>();
            for (var i = 1; i < 10; i++)
            {
                tokens.Add(new Offer
                {
                    CollectionId = $"{i << 3}",
                    TokenId = $"{i}",
                    CreatedDate = DateTime.Now,
                    BuyerAddress = "B213123123",
                    SellerAddress = "S213123123",
                    Price = $"{i}",
                    OfferStatus = "Completed"
                });
            }

            return tokens;
        }
    }
}

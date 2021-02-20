using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWebApi.Domain.DTO
{
    public class Offer
    {
        public string CollectionId { get; set; }
        public string TokenId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string SellerAddress { get; set; }
        public string BuyerAddress { get; set; }
        public string Price { get; set; }
        public string OfferStatus { get; set; }
    }
}

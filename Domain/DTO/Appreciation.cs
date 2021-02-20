using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWebApi.Domain.DTO
{
    public class Appreciation
    {
        public string CollectionId { get; set; }
        public string TokenId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string IpfsUrl { get; set; }
        public string Artist { get; set; }
        public string Appreciator { get; set; }
        public string Amount { get; set; }
    }
}

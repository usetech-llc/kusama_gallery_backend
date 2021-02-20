using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWebApi.Domain.DTO
{
    public class Token
    {
        public string CollectionId { get; set; }
        public string TokenId { get; set; }
        public string Creator { get; set; }
        public string OwnerAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Metadata { get; set; }
        public string Status { get; set; }
        public string ReportReason { get; set; }
    }
}

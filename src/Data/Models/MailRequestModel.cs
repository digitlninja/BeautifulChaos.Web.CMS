using System.Net;

namespace Data.Models
{
    public class MailRequestModel
    {
        public bool MissingParameter { get; set; }
        public bool MailSent { get; set; }
        public HttpStatusCode ResponseCode { get; set; }
        public string ResponseBody { get; set; }
    }
}
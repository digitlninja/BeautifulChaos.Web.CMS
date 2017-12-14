using System.Net;

namespace Web.Models
{
    public class MailRequestModel
    {
        public bool MissingParameter { get; set; }
        public bool MailSent { get; set; }
        public HttpStatusCode ResponseCode { get; set; }
        public string ResponseBody { get; set; }
    }
}
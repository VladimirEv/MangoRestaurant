using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using static Mango.Web.SD;

namespace Mango.Web.Models
{
    public class ApiRequest
    {
        public ApiType ApiType { get; set; }
        public string? Url { get; set; }
        public object Data { get; set; }
        public string? AccessToken { get; set; }
    }
}

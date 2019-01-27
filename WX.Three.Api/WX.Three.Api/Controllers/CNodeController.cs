using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WX.Three.Api.Controllers
{
    public class CNodeController : ApiController
    {
        [HttpGet]
        public List<Info> topics()
        {
            List<Info> list = new List<Info>();
            list.Add(new Info() { ID = 1, Title = "news" });
            return list;
        }
    }
    public class Info
    {
        public int ID { get; set; }
        public string Title { get; set; }
    }
}


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
            list.Add(new Info() {
                id = 1,
                title = "news",
                last_reply_at ="2018-12-2",
                author=new Author()
                {
                    loginname="张三"
                },
                reply_count=20,
                visit_count=100,
                tab="good"
            });
            list.Add(new Info()
            {
                id = 2,
                title = "这是一个标题",
                last_reply_at = "2016-11-23",
                author = new Author()
                {
                    loginname = "李四"
                },
                reply_count = 600,
                visit_count = 3210,
                tab = "share"
            });
            return list;
        }
    }
    public class Info
    {
        public int id { get; set; }
        public string title { get; set; }
        public string last_reply_at { get; set; }
        public Author author { get; set; }
        public int reply_count { get; set; }
        public int visit_count { get; set; }
        public string tab { get; set; }
    }
    public class Author
    {
        public string avatar_url { get; set; }
        public string loginname { get; set; }
    }
}


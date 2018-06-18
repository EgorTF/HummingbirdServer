using Hummingbird.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Hummingbird.WebAPI.Controllers.Ext
{
    /// <summary>
    /// 新闻
    /// </summary>
    [ControllerGroup("扩展数据", "新闻")]
    [RoutePrefix("api/ext/news")]
    public class NewsController : ApiController
    {
        /// <summary>
        /// 获取新闻列表信息
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetNewsList")]
        public List<News> GetNewsList()
        {
            List<News> list = new List<News>
            {
                new News{ NewsId = 1, Title = "", Content = ""}
            };
            return list;
        }
    }
}

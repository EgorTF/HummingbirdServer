using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hummingbird.Model
{
    /// <summary>
    /// 新闻实体类
    /// </summary>
    public class News
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int NewsId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 正文
        /// </summary>
        public string Content { get; set; }
    }
}

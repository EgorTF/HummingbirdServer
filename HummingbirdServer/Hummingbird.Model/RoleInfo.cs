using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hummingbird.Model
{
    /// <summary>
    /// 角色信息实体类
    /// </summary>
    public class RoleInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// 角色名
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 角色描述
        /// </summary>
        public string Description { get; set; }
    }
}

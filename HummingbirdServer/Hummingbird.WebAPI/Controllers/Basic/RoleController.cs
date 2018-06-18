using Hummingbird.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Hummingbird.WebAPI.Controllers.Basic
{
    /// <summary>
    /// 角色
    /// </summary>
    [ControllerGroup("基础数据", "角色")]
    [RoutePrefix("api/basic/role")]
    public class RoleController : ApiController
    {
        /// <summary>
        /// 根据ID获取单个角色的详细信息
        /// </summary>
        /// <param name="id">人员ID</param>
        /// <returns></returns>
        [HttpGet, Route("GetRoleInfo")]
        public RoleInfo GetRoleInfo(int id)
        {
            return new RoleInfo { RoleId = id, RoleName = "超级管理员", Description = "超级管理员" };
        }
    }
}

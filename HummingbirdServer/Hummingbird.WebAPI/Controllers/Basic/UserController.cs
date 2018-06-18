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
    /// 用户
    /// </summary>
    [ControllerGroup("基础数据", "用户")]
    [RoutePrefix("api/basic/user")]
    public class UserController : ApiController
    {
        /// <summary>
        /// 根据ID获取单个人的详细信息
        /// </summary>
        /// <param name="userId">人员ID</param>
        /// <returns></returns>
        [HttpGet, Route("GetUserInfo")]
        public UserInfo GetUserInfo(int userId)
        {
            return new UserInfo { UserId = userId, UserName = "张三", Password = "admin888" };
        }

        /// <summary>
        /// 获取人员列表信息
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetUserList")]
        public List<UserInfo> GetUserList()
        {
            List<UserInfo> list = new List<UserInfo>
            {
                new UserInfo{ UserId = 3, UserName = "张三", Password = "admin888"},
                new UserInfo{ UserId = 4, UserName = "李四", Password = "admin888"},
                new UserInfo{ UserId = 5, UserName = "王五", Password = "admin888"},
                new UserInfo{ UserId = 6, UserName = "小七", Password = "admin888"}
            };
            return list;
        }

        /// <summary>
        /// 添加人员
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        [HttpPost, Route("add")]
        public int AddProduct(UserInfo userInfo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 更新人员
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userInfo"></param>
        [HttpPost, Route("update")]
        public void UpdateUserInfo(int userId, UserInfo userInfo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除人员
        /// </summary>
        /// <param name="userId"></param>
        [HttpDelete, Route("delete")]
        public void DeleteUserInfo(int userId)
        {
            throw new NotImplementedException();
        }

    }
}

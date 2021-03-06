﻿using System;
using System.Collections.Generic;
using BeiDream.Core.Domain.Services;

namespace BeiDream.Demo.Domain.DomainServices.Contracts
{
    /// <summary>
    /// 用户领域服务接口
    /// </summary>
    public interface IUserDomainService : IDomainService
    {
        /// <summary>
        /// 设置角色
        /// </summary>
        /// <param name="userId">被设置角色的用户Id</param>
        /// <param name="roleIds">选择的角色集合</param>
        void SetRoles(Guid userId, List<Guid> roleIds);
    }
}
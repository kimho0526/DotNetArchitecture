using System;
using Solution.Model.Enums;
using Solution.Model.Models;

namespace Solution.Domain.Domains.UserLog
{
    public static class UserLogFactory
    {
        public static UserLogModel Create(long userId, LogType logType)
        {
            return new UserLogModel
            {
                UserId = userId,
                LogType = logType,
                DateTime = DateTime.UtcNow
            };
        }
    }
}

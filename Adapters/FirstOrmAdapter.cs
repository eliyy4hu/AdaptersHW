using Example_04.Homework.FirstOrmLibrary;
using Example_04.Homework.Models;

namespace Example_04.Homework.Clients
{
    public class FirstOrmAdapter: IOrmAdapter
    {
        private readonly IFirstOrm<DbUserEntity> firstOrmUsers;
        private readonly IFirstOrm<DbUserInfoEntity> firstOrmUserInfo;
        public FirstOrmAdapter(IFirstOrm<DbUserEntity> firstOrmUsers, IFirstOrm<DbUserInfoEntity> firstOrmUserInfo)
        {
            this.firstOrmUsers = firstOrmUsers;
            this.firstOrmUserInfo = firstOrmUserInfo;
        }
        public DbUserEntity GetUserById(int userId)
        {
            return firstOrmUsers.Read(userId);
        }

        public DbUserInfoEntity GetUserInfoById(int userInfoId)
        {
            return firstOrmUserInfo.Read(userInfoId);
        }

        public void AddUser(DbUserEntity user)
        {
            firstOrmUsers.Add(user);
        }

        public void AddUserInfo(DbUserInfoEntity userInfo)
        {
            firstOrmUserInfo.Add(userInfo);
        }

        public void RemoveUserById(int userId)
        {
            var user = GetUserById(userId);
            firstOrmUsers.Delete(user);
        }

        public void RemoveUserInfoById(int userInfoId)
        {
            var userInfo = GetUserInfoById(userInfoId);
            firstOrmUserInfo.Delete(userInfo);
        }
    }
}
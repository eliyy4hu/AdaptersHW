using System.Linq;
using Example_04.Homework.Models;
using Example_04.Homework.SecondOrmLibrary;

namespace Example_04.Homework.Clients
{
    public class SecondOrmAdapter : IOrmAdapter
    {
        private readonly ISecondOrm secondOrm;

        public SecondOrmAdapter(ISecondOrm secondOrm)
        {
            this.secondOrm = secondOrm;
        }

        public DbUserEntity GetUserById(int userId)
        {
            return secondOrm.Context.Users.First(i => i.Id == userId);
        }

        public DbUserInfoEntity GetUserInfoById(int userInfoId)
        {
            return secondOrm.Context.UserInfos.First(i => i.Id == userInfoId);
        }

        public void AddUser(DbUserEntity user)
        {
            secondOrm.Context.Users.Add(user);
        }

        public void AddUserInfo(DbUserInfoEntity userInfo)
        {
            secondOrm.Context.UserInfos.Add(userInfo);
        }

        public void RemoveUserById(int userId)
        {
            var user = GetUserById(userId);
            secondOrm.Context.Users.Remove(user);
        }

        public void RemoveUserInfoById(int userInfoId)
        {
            var userInfo = GetUserInfoById(userInfoId);
            secondOrm.Context.UserInfos.Remove(userInfo);
        }
    }
}
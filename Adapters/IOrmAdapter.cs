using Example_04.Homework.Models;

namespace Example_04.Homework.Clients
{
    public interface IOrmAdapter // ITarget
    {
        DbUserEntity GetUserById(int userId);
        DbUserInfoEntity GetUserInfoById(int userInfoId);
        void AddUser(DbUserEntity user);
        void AddUserInfo(DbUserInfoEntity userInfo);
        void RemoveUserById(int userId);
        void RemoveUserInfoById(int userInfoId);
    }
}
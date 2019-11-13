using System.Linq;
using Example_04.Homework.FirstOrmLibrary;
using Example_04.Homework.Models;
using Example_04.Homework.SecondOrmLibrary;

namespace Example_04.Homework.Clients
{
    public class UserClient
    {
        private IOrmAdapter _ormAdapter;

        private IFirstOrm<DbUserEntity> _firstOrm1;
        private IFirstOrm<DbUserInfoEntity> _firstOrm2;

        private ISecondOrm _secondOrm;

        private bool _useFirstOrm = true;

        public (DbUserEntity, DbUserInfoEntity) Get(int userId)
        {
            var user = _ormAdapter.GetUserById(userId);
            var userInfo = _ormAdapter.GetUserInfoById(user.InfoId);
            return (user, userInfo);
        }

        public void Add(DbUserEntity user, DbUserInfoEntity userInfo)
        {
            _ormAdapter.AddUser(user);
            _ormAdapter.AddUserInfo(userInfo);
        }

        public void Remove(int userId)
        {
            var user = _ormAdapter.GetUserById(userId);
            _ormAdapter.RemoveUserInfoById(user.InfoId);
            _ormAdapter.RemoveUserById(userId);
        }

        public UserClient(IOrmAdapter ormAdapter)
        {
            _ormAdapter = ormAdapter;
        }
    }
}

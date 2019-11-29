using System.Collections.Generic;
using System.Linq;
using PictureShopDataAccessContracts;
using PictureShopEntity;

namespace PictureShopDataAccess
{
    public class UserInfoAccess : IUserInfoAccess
    {
        private List<UserInfo> _userInfoDb;

        public UserInfoAccess()
        {
            InitDb();
        }

        public IEnumerable<UserInfo> GetAllUsers()
        {
            Context.DoConnectionAndPetition();
            return _userInfoDb;
        }
        public UserInfo GetUserInfoById(int id)
        {
            Context.DoConnectionAndPetition();
            return _userInfoDb.FirstOrDefault(user => user.Id == id);
        }

        private void InitDb()
        {
            _userInfoDb = new List<UserInfo>();
            for (var i = 0; i < 1000; i++)
            {
                _userInfoDb.Add(new UserInfo()
                {
                    Id = i,
                    Name = $"Name user {i}",
                    Surname = $"Surname user {i}"
                });
            }
        }
    }
}

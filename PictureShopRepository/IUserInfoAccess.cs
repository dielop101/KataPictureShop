using PictureShopEntity;
using System.Collections.Generic;

namespace PictureShopDataAccessContracts
{
    public interface IUserInfoAccess
    {
        UserInfo GetUserInfoById(int id);
        IEnumerable<UserInfo> GetAllUsers();
    }
}

using PictureShopEntity;

namespace PictureShopDataAccessContracts
{
    public interface IUserInfoAccess
    {
        UserInfo GetUserInfoById(int id);
    }
}

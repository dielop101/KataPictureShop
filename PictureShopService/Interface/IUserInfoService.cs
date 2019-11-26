using PictureShopService.Dto;

namespace PictureShopService.Interface
{
    public interface IUserInfoService
    {
        UserInfoDto GetUserInfoById(int id);
    }
}

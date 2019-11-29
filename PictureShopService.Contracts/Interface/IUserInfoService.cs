using PictureShopService.Contracts.Dto;
using System.Collections.Generic;

namespace PictureShopService.Contracts.Interface
{
    public interface IUserInfoService
    {
        IEnumerable<UserInfoDto> GetAllUsers();
        UserInfoDto GetUserInfoById(int id);
    }
}

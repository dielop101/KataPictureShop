using PictureShopDataAccessContracts;
using PictureShopService.Dto;
using PictureShopService.Interface;

namespace PictureShopService
{
    public class UserInfoService : IUserInfoService
    {
        private readonly IUserInfoAccess _userInfoData;
        public UserInfoService(IUserInfoAccess userInfoData)
        {
            _userInfoData = userInfoData;
        }

        public UserInfoDto GetUserInfoById(int id)
        {
            var userInfoModel = _userInfoData.GetUserInfoById(id);

            return new UserInfoDto()
            {
                Id = userInfoModel.Id,
                Name = userInfoModel.Name,
                Surname = userInfoModel.Surname
            };
        }
    }
}

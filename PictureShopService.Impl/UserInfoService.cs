using System.Collections.Generic;
using PictureShopDataAccessContracts;
using PictureShopEntity;
using PictureShopService.Contracts.Dto;
using PictureShopService.Contracts.Interface;

namespace PictureShopService.Impl
{
    public class UserInfoService : IUserInfoService
    {
        private readonly IUserInfoAccess _userInfoData;
        public UserInfoService(IUserInfoAccess userInfoData)
        {
            _userInfoData = userInfoData;
        }

        public IEnumerable<UserInfoDto> GetAllUsers()
        {
            var usersInfoData = _userInfoData.GetAllUsers();

            foreach (var userInfoData in usersInfoData)
            {
                yield return MapEntityToDto(userInfoData);
            }
        }

        public UserInfoDto GetUserInfoById(int id)
        {
            var userInfoData = _userInfoData.GetUserInfoById(id);

            if (userInfoData is null) return new UserInfoDto();

            return MapEntityToDto(userInfoData);
        }

        private UserInfoDto MapEntityToDto(UserInfo userInfoData)
        {
            return new UserInfoDto()
            {
                Id = userInfoData.Id,
                Name = userInfoData.Name,
                Surname = userInfoData.Surname
            };
        }
    }
}

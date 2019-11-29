using PictureShopDataAccessContracts;
using PictureShopEntity;
using PictureShopService.Contracts.Dto;
using PictureShopService.Contracts.Interface;
using System.Collections.Generic;

namespace PictureShopService.Impl
{
    public class PictureInfoService : IPictureInfoService
    {
        private readonly IPictureInfoAccess _pictureInfoAccess;
        public PictureInfoService(IPictureInfoAccess pictureInfoAccess)
        {
            _pictureInfoAccess = pictureInfoAccess;
        }

        public IEnumerable<PictureInfoDto> GetAllPictures()
        {
            var picturesInfoData = _pictureInfoAccess.GetAllPictures();

            foreach (var pictureInfoData in picturesInfoData)
            {
                yield return MapEntityToDto(pictureInfoData);
            }
        }

        public PictureInfoDto GetPictureInfoById(int id)
        {
            var pictureInfoData = _pictureInfoAccess.GetPictureInfoById(id);

            if (pictureInfoData is null) return new PictureInfoDto();

            return MapEntityToDto(pictureInfoData);
        }

        private PictureInfoDto MapEntityToDto(PictureInfo pictureInfoData)
        {
            return new PictureInfoDto()
            {
                Id = pictureInfoData.Id,
                Name = pictureInfoData.Name,
                Description = pictureInfoData.Description,
                Content = pictureInfoData.Content
            };
        }
    }
}

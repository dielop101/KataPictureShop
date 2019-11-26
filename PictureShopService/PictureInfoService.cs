using PictureShopDataAccessContracts;
using PictureShopService.Dto;
using PictureShopService.Interface;

namespace PictureShopService
{
    public class PictureInfoService : IPictureInfoService
    {
        private readonly IPictureInfoAccess _pictureInfoAccess;
        public PictureInfoService(IPictureInfoAccess pictureInfoAccess)
        {
            _pictureInfoAccess = pictureInfoAccess;
        }

        public PictureInfoDto GetPictureInfoById(int id)
        {
            var pictureInfoModel = _pictureInfoAccess.GetPictureInfoById(id);

            return new PictureInfoDto()
            {
                Id = pictureInfoModel.Id,
                Name = pictureInfoModel.Name,
                Description = pictureInfoModel.Description,
                Content = pictureInfoModel.Content
            };
        }
    }
}

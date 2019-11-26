using PictureShopService.Dto;

namespace PictureShopService.Interface
{
    public interface IPictureInfoService
    {
        PictureInfoDto GetPictureInfoById(int id);
    }
}

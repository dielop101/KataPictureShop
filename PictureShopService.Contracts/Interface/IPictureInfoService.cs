using PictureShopService.Contracts.Dto;
using System.Collections.Generic;

namespace PictureShopService.Contracts.Interface
{
    public interface IPictureInfoService
    {
        IEnumerable<PictureInfoDto> GetAllPictures();
        PictureInfoDto GetPictureInfoById(int id);
    }
}

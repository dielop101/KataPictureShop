using PictureShopEntity;
using System.Collections.Generic;

namespace PictureShopDataAccessContracts
{
    public interface IPictureInfoAccess
    {
        PictureInfo GetPictureInfoById(int id);
        IEnumerable<PictureInfo> GetAllPictures();
    }
}

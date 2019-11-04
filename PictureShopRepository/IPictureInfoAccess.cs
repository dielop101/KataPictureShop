using PictureShopEntity;

namespace PictureShopDataAccessContracts
{
    public interface IPictureInfoAccess
    {
        PictureInfo GetPictureInfoById(int id);
    }
}

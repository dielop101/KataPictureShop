using PictureShopDataAccessContracts;
using PictureShopEntity;

namespace PictureShopDataAccess
{
    public class PictureInfoAccess : IPictureInfoAccess
    {
        public PictureInfo GetPictureInfoById(int id)
        {
            Context.DoConnectionAndPetition();

            return new PictureInfo()
            {
                Id = id,
                Name = "Name",
                Description = "Description",
                Content = new byte[] { 1, 2, 3, 4, 5 }
            };
        }
    }
}

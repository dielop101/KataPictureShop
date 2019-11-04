using PictureShopDataAccessContracts;
using PictureShopEntity;

namespace PictureShopDataAccess
{
    public class PictureInfoAccess : IPictureInfoAccess
    {
        private readonly Context _context;
        public PictureInfoAccess(Context context)
        {
            _context = context;
        }

        public PictureInfo GetPictureInfoById(int id)
        {
            _context.DoConnectionAndPetition();

            return new PictureInfo()
            {
                Id = id,
                Name = "Name",
                Description = "Description"
            };
        }
    }
}

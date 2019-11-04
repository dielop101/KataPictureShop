using PictureShopDataAccessContracts;
using PictureShopEntity;

namespace PictureShopDataAccess
{
    public class UserInfoAccess : IUserInfoAccess
    {
        private readonly Context _context;
        public UserInfoAccess(Context context)
        {
            _context = context;
        }

        public UserInfo GetUserInfoById(int id)
        {
            _context.DoConnectionAndPetition();

            return new UserInfo()
            {
                Id = id,
                Name = "name",
                Surname = "surname"
            };
        }


    }
}

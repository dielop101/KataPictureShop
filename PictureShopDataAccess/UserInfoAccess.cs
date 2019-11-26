using PictureShopDataAccessContracts;
using PictureShopEntity;

namespace PictureShopDataAccess
{
    public class UserInfoAccess : IUserInfoAccess
    {

        public UserInfo GetUserInfoById(int id)
        {
            Context.DoConnectionAndPetition();

            return new UserInfo()
            {
                Id = id,
                Name = "name",
                Surname = "surname"
            };
        }


    }
}

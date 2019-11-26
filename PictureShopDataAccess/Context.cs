using System.Threading;

namespace PictureShopDataAccess
{
    public static class Context
    {
        public static bool DoConnectionAndPetition()
        {
            Thread.Sleep(5000);
            return true;
        }
    }
}
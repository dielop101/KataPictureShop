using Newtonsoft.Json;
using PictureShopDataAccess;
using PictureShopService;
using System;

namespace KataPictureShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new UserInfoService(
                new UserInfoAccess(
                    new Context())
                );
            var dto = service.GetUserInfoById(1);
            Console.WriteLine(JsonConvert.SerializeObject(dto));
            dto = service.GetUserInfoById(2);
            Console.WriteLine(JsonConvert.SerializeObject(dto));
            dto = service.GetUserInfoById(3);
            Console.WriteLine(JsonConvert.SerializeObject(dto));
        }
    }
}

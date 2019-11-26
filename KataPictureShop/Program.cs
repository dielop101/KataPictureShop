using Newtonsoft.Json;
using PictureShopDataAccess;
using PictureShopService;
using System;
using Microsoft.Extensions.DependencyInjection;
using PictureShopService.Interface;
using PictureShopDataAccessContracts;
using System.Threading.Tasks;

namespace KataPictureShop
{
    class Program
    {
        private static IUserInfoService _userInfoService;
        private static IPictureInfoService _pictureInfoService;

        static void Main(string[] args)
        {
            BuildServices();

            var task1 = Task.Run(() => PrintUsers());
            var task2 = Task.Run(() => PrintPictures());

            task1.Wait();
            task2.Wait();
        }

        private static void PrintUsers()
        {
            for (var i = 0; i < 10; i++)
            {
                var user = _userInfoService.GetUserInfoById(i);
                Console.WriteLine(JsonConvert.SerializeObject(user));
            }
        }

        private static void PrintPictures()
        {
            for (var i = 0; i < 10; i++)
            {
                var picture = _pictureInfoService.GetPictureInfoById(i);
                Console.WriteLine(JsonConvert.SerializeObject(picture));
            }
        }

        private static void BuildServices()
        {
            var serviceProvider = new ServiceCollection()
            .AddSingleton<IPictureInfoAccess, PictureInfoAccess>()
            .AddSingleton<IUserInfoAccess, UserInfoAccess>()
            .AddSingleton<IUserInfoService, UserInfoService>()
            .AddSingleton<IPictureInfoService, PictureInfoService>()
            .BuildServiceProvider();

            _userInfoService = serviceProvider.GetService<IUserInfoService>();
            _pictureInfoService = serviceProvider.GetService<IPictureInfoService>();
        }
    }
}

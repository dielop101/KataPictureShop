using PictureShopDataAccessContracts;
using PictureShopEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace PictureShopDataAccess
{
    public class PictureInfoAccess : IPictureInfoAccess
    {
        private List<PictureInfo> _pictureInfoDb;

        public PictureInfoAccess()
        {
            InitDb();
        }

        public IEnumerable<PictureInfo> GetAllPictures()
        {
            Context.DoConnectionAndPetition();
            return _pictureInfoDb;
        }
        public PictureInfo GetPictureInfoById(int id)
        {
            Context.DoConnectionAndPetition();
            return _pictureInfoDb.FirstOrDefault(picture => picture.Id == id);
        }

        private void InitDb()
        {
            _pictureInfoDb = new List<PictureInfo>();

            var random = new Byte[1000];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(random);

            for (var i = 0; i < 1000; i++)
            {
                _pictureInfoDb.Add(new PictureInfo()
                {
                    Id = i,
                    Name = $"Name picture {i}",
                    Description = $"Description picture {i}",
                    Content = random
                });
            }
        }
    }
}

using Infraestructure.Data.Context;
using Infraestructure.Data.Entities;
using Services.DTO;
using Services.Interfaces;
using System;

namespace Services.Services
{
    public class ImageService : IImagesService
    {
        private DataBaseContext _context;

        public ImageService(DataBaseContext context)
        {
            _context = context;
        }
        public bool ConvertImage(ImagesDTO imagetoconvert)
        {
            try
            {



                foreach (var item in imagetoconvert.Names)
                {
                    Images Image = new Images();
                    Image.FinalSize = imagetoconvert.FinalSize;
                    Image.Date = imagetoconvert.Date;
                    Image.Names = item;
                    Image.User = imagetoconvert.User;
                    _context.Images.Add(Image);
                    _context.SaveChanges();

                }

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
    }
}

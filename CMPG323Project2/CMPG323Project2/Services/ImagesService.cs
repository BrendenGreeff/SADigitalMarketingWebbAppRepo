using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMPG323Project2.Data;
using CMPG323Project2.Models;

namespace CMPG323Project2.Services
{
    public class ImagesService
    {
        private readonly ApplicationDbContext _dbcontext;

        public ImagesService(ApplicationDbContext _db)
        {
            _dbcontext = _db;
        }

        //Function of the boolean to insert records/images into database:
        public bool UploadImages(ImagesModels im)
        {
            _dbcontext.images.Add(im);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}

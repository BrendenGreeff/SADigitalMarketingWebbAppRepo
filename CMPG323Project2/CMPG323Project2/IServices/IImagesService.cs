using CMPG323Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace CMPG323Project2.IServices
{
    public interface IImagesService
    {
        ImagesModels Save(ImagesModels oImages);
        ImagesModels GetSavedImagesModels();

    }
}

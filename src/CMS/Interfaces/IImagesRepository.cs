using System.Collections.Generic;
using Data.Entities;

namespace CMS.Interfaces
{
    public interface IImagesRepository
    {
        List<Image> Entities();
        Image Entity();
    }
}

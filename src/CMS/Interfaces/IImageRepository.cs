using System.Collections.Generic;
using Data.Entities;

namespace CMS.Interfaces
{
    public interface IImageRepository
    {
        List<Image> Entities();
        Image Entity();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Interfaces;
using Data.Contexts;
using Data.Entities;

namespace CMS.Repositories
{
    public class ImagesRepository : BeautifulChaosRepository, IImagesRepository
    {
        public ImagesRepository(BeautifulChaosContext context)
        :base(context)
        {
        }

        public Image Entity()
        {
            var query = this.Context.Images;

            var entity = query.FirstOrDefault();
            if (entity == null)
                return null;

            return entity;
        }

        public List<Image> Entities()
        {
            var query = this.Context.Images;
            var entities = query.ToList();

            if (entities.Count <= 0 || entities == null)
                return null;

            return entities;
        }
    }
}

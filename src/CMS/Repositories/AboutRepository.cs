using System;
using System.Linq;
using CMS.Extensions;
using CMS.Interfaces;
using CMS.Models;
using Data.Contexts;
using Data.Entities;

namespace CMS.Repositories
{
    public class AboutRepository : BeautifulChaosRepository, IAboutRepository
    {
        public AboutRepository(BeautifulChaosContext context) 
            : base(context)
        {
        }

        public About Entity()
        {
            var query = this.Context.About;

            var entity = query.FirstOrDefault();
            if (entity == null)
                return null;

            return entity;
        }
    }
}

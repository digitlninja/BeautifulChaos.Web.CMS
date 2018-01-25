using System;
using System.Linq;
using CMS.Extensions;
using CMS.Interfaces;
using CMS.Models;
using Data.Contexts;

namespace CMS.Repositories
{
    public class AboutRepository : IAboutRepository
    {
        public BeautifulChaosContext Context { get; }

        public AboutRepository(BeautifulChaosContext context)
        {
            if(context == null)
                throw new ArgumentNullException(nameof(context));

            this.Context = context;
        }

        public AboutModel Entity()
        {
            var entity = this.Context.About.FirstOrDefault();
            if (entity == null)
                return null;

            return entity.ToModel();
        }
    }
}

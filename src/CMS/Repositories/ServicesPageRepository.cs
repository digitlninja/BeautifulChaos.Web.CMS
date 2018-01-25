using System.Linq;
using CMS.Interfaces;
using Data.Contexts;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CMS.Repositories
{
    public class ServicesPageRepository : BeautifulChaosRepository, IServicesPageRepository
    {
        public BeautifulChaosContext Context { get; }

        public ServicesPageRepository(BeautifulChaosContext context)
            : base(context)
        {
        }

        public ServicesPage Entity()
        {
            var query = this.Context.ServicesPage.Include(x => x.Services);

            var entity = query.FirstOrDefault();
            if (entity == null)
                return null;

            return entity;
        }   
    }
}

using System.Linq;
using CMS.Interfaces;
using Data.Contexts;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CMS.Repositories
{
    public class WorkRepository : BeautifulChaosRepository, IWorkRepository
    {
        public WorkRepository(BeautifulChaosContext context)
        :base(context)
            {
            
        }

        public Work Entity()
        {
            var query = this.Context.Work.Include(x => x.Images);

            var entity = query.FirstOrDefault();
            if (entity == null)
                return null;

            return entity;
        }
    }
}

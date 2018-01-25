using System.Linq;
using CMS.Interfaces;
using Data.Contexts;
using Data.Entities;

namespace CMS.Repositories
{
    public class TestimonialsPageRepository : BeautifulChaosRepository, ITestimonialsPageRepository
    {
        public TestimonialsPageRepository(BeautifulChaosContext context) : base(context)
        {
        }

        public TestimonialsPage Entity()
        {
            var query = this.Context.TestimonialsPage;

            var entity = query.FirstOrDefault();
            if (entity == null)
                return null;

            return entity;
        }

    }
}

using System.Collections.Generic;
using System.Linq;
using CMS.Interfaces;
using Data.Contexts;
using Data.Entities;

namespace CMS.Repositories
{
    public class TestimonialsRepository : BeautifulChaosRepository, ITestimonialsRepository
    {
        public TestimonialsRepository(BeautifulChaosContext context) : base(context)
        {
        }

        public Testimonial Entity()
        {
            var query = this.Context.Testimonial;

            var entity = query.FirstOrDefault();
            if (entity == null)
                return null;

            return entity;
        }

        public List<Testimonial> Entities()
        {
            var query = this.Context.Testimonial;

            var entities = query.ToList();
            if (entities.Count <= 0)
                return null;

            return entities;
        }

       
    }
}

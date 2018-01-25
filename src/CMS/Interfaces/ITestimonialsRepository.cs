using System.Collections.Generic;
using Data.Entities;

namespace CMS.Interfaces
{
    public interface ITestimonialsRepository
    {
        Testimonial Entity();
        List<Testimonial> Entities();
    }
}

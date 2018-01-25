using CMS.Models;
using Data.Contexts;
using Data.Entities;

namespace CMS.Interfaces
{
    public interface IServicesPageRepository
    {
        BeautifulChaosContext Context { get; }
        ServicesPage Entity();
    }
}

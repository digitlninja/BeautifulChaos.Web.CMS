using System;
using Data.Contexts;

namespace CMS.Repositories
{
    public class BeautifulChaosRepository
    {
        public BeautifulChaosContext Context { get; }

        public BeautifulChaosRepository(BeautifulChaosContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            this.Context = context;
        }
    }
}

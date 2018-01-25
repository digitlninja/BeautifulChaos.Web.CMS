﻿using CMS.Models;
using Data.Contexts;
using Data.Entities;

namespace CMS.Interfaces
{
    public interface IAboutRepository
    {
        BeautifulChaosContext Context { get; }
        About Entity();
    }
}

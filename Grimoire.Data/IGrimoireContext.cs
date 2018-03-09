﻿using Grimoire.Data.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Grimoire.Data
{
    public interface IGrimoireContext
    {
        DbSet<School> Schools { get; set; }
        DbSet<Spell> Spells { get; set; }
    }
}
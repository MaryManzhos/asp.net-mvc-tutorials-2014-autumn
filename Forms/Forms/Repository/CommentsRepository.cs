﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Forms.Repository
{
    public static class CommentsRepository
    {
        public static readonly ICollection<string> Comments = new Collection<string>();
    }
}
﻿using System.Collections.Generic;
using System.Linq;

namespace NetAdmin.Helpers.Extensions
{
    public static class EnumerableExtensions
    {
        public static bool HaveItems<T>(this IEnumerable<T> collection)
        {
            return collection != null && collection.Any();
        }
    }
}
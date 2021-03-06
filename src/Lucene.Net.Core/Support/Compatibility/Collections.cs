﻿using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Lucene.Net
{
    public static class Collections
    {
        public static ISet<T> Singleton<T>(T o)
        {
            return ImmutableHashSet.Create(o);
        }

        public static IList<T> EmptyList<T>()
        {
            return ImmutableList<T>.Empty;
        }

        public static IList<T> UnmodifiableList<T>(IEnumerable<T> items)
        {
            return ImmutableList.Create<T>(items.ToArray());
        }
    }
}

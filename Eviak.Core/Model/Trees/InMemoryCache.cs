using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eviak.Core.Model.Nodes;

namespace Eviak.Core.Model.Trees
{
    public class InMemoryCache : ITreeCache
    {
        public void Get(CacheKey key)
        {
            throw new NotImplementedException();
        }

        public void Put(CacheKey key, Node node)
        {
            throw new NotImplementedException();
        }

        public void Remove(CacheKey key)
        {
            throw new NotImplementedException();
        }
    }
}

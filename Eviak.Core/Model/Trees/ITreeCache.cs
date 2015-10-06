using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eviak.Core.Model.Trees
{
    public interface ITreeCache
    {
        void Put(CacheKey key, Nodes.Node node);
        void Get(CacheKey key);
        void Remove(CacheKey key);
    }
}
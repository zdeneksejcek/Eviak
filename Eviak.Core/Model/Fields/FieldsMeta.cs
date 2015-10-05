using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eviak.Core.Model.Fields
{
    internal class FieldsMeta : IEnumerable<FieldMeta>
    {
        private List<FieldMeta> _fields = new List<FieldMeta>();

        public IEnumerator<FieldMeta> GetEnumerator()
        {
            return _fields.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
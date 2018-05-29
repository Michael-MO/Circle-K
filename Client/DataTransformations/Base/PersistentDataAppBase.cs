using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.InMemory.Implementation;
using Data.InMemory.Interfaces;

namespace Client.DataTransformations.Base
{
    public abstract class PersistentDataAppBase : IStorable
    {
        public abstract int Key { get; set; }
    }
}

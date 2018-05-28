using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.InMemory.Implementation;
using Data.InMemory.Interfaces;

namespace WebService.Models
{
    public abstract class PersistentDataAppBase
    {
        public abstract int Key { get; set; }
    }
}

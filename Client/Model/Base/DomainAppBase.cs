using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.InMemory.Implementation;

namespace Client.Model.Base
{
    public abstract class DomainAppBase : StorableBase
    {


        protected DomainAppBase(int key)
            : base(key)
        {
        }

        //public int ImageKey
        //{
        //    get;
        //    set;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public abstract class AbstractBasicDescriptor : IBasicDescriptor
    {

        public abstract void AddDescription();


        public abstract void SubDescription();



        public abstract void MultDescription();


        public abstract void DivDescription();

    }
}

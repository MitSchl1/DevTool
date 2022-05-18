using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class BasicDescriptor : AbstractBasicDescriptor
    {
        private Addition add = new();
        private Substraction sub = new();
        private Multiplication mult = new();
        private Division div = new();

        public override void AddDescription()
        {
            add.Definition();
        }
  
        public override void SubDescription()
        {
            sub.Definition();
        }

        public override void MultDescription()
        {
            mult.Definition();
        }

        public override void DivDescription()
        {
            div.Definition();
        }
    }
}

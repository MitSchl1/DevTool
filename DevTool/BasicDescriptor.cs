using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    internal class BasicDescriptor
    {
        private Addition add = new();
        private Substraction sub = new();
        private Multiplication mult = new();
        private Division div = new();

        public void AddDescription()
        {
            add.Definition();
        }
        public void SubDescription()
        {
            sub.Definition();
        }
        public void MultDescription()
        {
            mult.Definition();
        }
        public void DivDescription()
        {
            div.Definition();
        }
    }
}

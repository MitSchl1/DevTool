using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class AdvancedDescriptor : BasicDescriptor
    {
        private Sin sin = new();
        private Cos cos = new();
        private Tan tan = new();
        private Log log = new();
        private Log10 log10 = new();
        private Log2 log2 = new();

        public void SinDescription()
        {
            sin.Definition();
        }
        public void CosDescription()
        {
            cos.Definition();
        }
        public void TanDescription()
        {
            tan.Definition();
        }
        public void LogDescription()
        {
            log.Definition();
        }
        public void Log10Description()
        {
            log10.Definition();
        }
        public void Log2Description()
        {
            log2.Definition();
        }

    }
}

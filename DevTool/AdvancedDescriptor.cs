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
        private Acos acos = new();
        private Acosh acosh = new();
        private Asin asin = new();
        private Asinh asinh = new();
        private Atan atan = new();
        private Atanh atanh = new();
        private Cosh cosh = new();
        private Sinh sinh = new();
        private Tanh tanh = new();
        private Sqrt sqrt = new();
        private Exp exp = new();
        private Pow pow = new();

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

        public void SinhDescription()
        {
            sinh.Definition();
        }
        public void CoshDescription()
        {
            cosh.Definition();
        }
        public void TanhDescription()
        {
            tanh.Definition();
        }
        public void AsinhDescription()
        {
            asinh.Definition();
        }
        public void AcoshDescription()
        {
            acosh.Definition();
        }
        public void AtanhDescription()
        {
            atanh.Definition();
        }
        public void AsinDescription()
        {
            asin.Definition();
        }
        public void AcosDescription()
        {
            acos.Definition();
        }
        public void AtanDescription()
        {
            atan.Definition();
        }

        public void SqrtDescription()
        {
            sqrt.Definition();
        }
        public void PowDescription()
        {
            pow.Definition();
        }
        public void ExpDescription()
        {
            exp.Definition();
        }
    }
}

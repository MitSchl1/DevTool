using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class Drawer
    {
        public void DrawShapes(IEnumerable<IShape> shapes)
        {
            foreach(IShape shape in shapes)
            {
                shape.DrawShape();
            }
        }
    }
}

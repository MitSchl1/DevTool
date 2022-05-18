using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class ShapeCalculator
    {
        public double ShapeCalculation(IEnumerable<Object> shapes)
        {
            foreach (var shape in shapes)
            {
                if(shape is Triangle)
                {
                    return TriangleShapeCalc(shape as Triangle);

                }else if (shape is Square)
                {
                   return  SquareShapeCalc(shape as Square);
                }
            }
            return 0;
 
        }
        private double TriangleShapeCalc(Triangle triangle)
        {
            throw new NotImplementedException();

        }
        private double SquareShapeCalc(Square square)
        {
            throw new NotImplementedException();

        }
    }
}

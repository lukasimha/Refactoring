using System.Linq;

namespace Refactoring
{
    public class CADApp 
    {
        void drawShapes(Graphics graphics, Shape[] shapes) 
        {
            for (int i = 0; i < shapes.Count(); i++) 
            {
                switch (shapes[i].ShapeType) 
                {
                    case Shape.TYPELINE: graphics.drawLine(shapes[i].P1, shapes[i].P2);
                                         break;
                    case Shape.TYPERECTANGLE: //draw the four edges.
                                        graphics.drawRectangle(shapes[i].P1, shapes[i].P2);
                                        break;
                    case Shape.TYPECIRCLE: graphics.drawCircle(shapes[i].P1, shapes[i].Radius);
                                        break;
                }   
            }
        }
    }
}

namespace Refactoring
{
    public class Shape 
    {
        public const int TYPELINE = 0;
        public const int TYPERECTANGLE = 1;
        public const int TYPECIRCLE = 2;
        
        int shapeType;
        
        //starting point of the line.
        //lower left corner of the rectangle.
        //center of the circle.

        Point p1;
        //ending point of the line.
        //upper right corner of the rectangle.
        //not used for the circle.
        
        Point p2;

        int radius;

        public Point P1
        {
            get { return p1; }
        }

        public Point P2
        {
            get { return p2; }
        }

        public int Radius
        {
            get { return radius; }
        }

        public int ShapeType
        {
            get { return shapeType; }
        }
    }
}

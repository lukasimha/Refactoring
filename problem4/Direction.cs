using System;

namespace Refactoring
{
    public class Direction
    {
        private char direction;
    
        public Direction(char direction)
        {
            this.direction = direction;
        }
    
        public Direction turnRight()
        {
            switch (direction)
            {
                case 'N':
                    return new Direction('E');
                case 'S':
                    return new Direction('W');
                case 'E':
                    return new Direction('S');
                case 'W':
                    return new Direction('N');
                default:
                    throw new Exception();
            }
        }
    
        public Direction turnLeft()
        {
            switch (direction)
            {
                case 'N':
                    return new Direction('W');
                case 'S':
                    return new Direction('E');
                case 'E':
                    return new Direction('N');
                case 'W':
                    return new Direction('S');
                default:
                    throw new Exception();
            }
        }
    }
}

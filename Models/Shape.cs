using Abstraction.Interfaces;

namespace Abstraction.Models
{
    public abstract class Shape:IShape
    {
        public  int Width {get;set;}
        public int GetArea()
        {
            return Width * Width ;
        }
        public abstract  int GetWidth();
    }
}
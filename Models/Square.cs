using Abstraction.Interfaces;

namespace Abstraction.Models
{
    public class Square : Shape
    {
       public override int GetWidth(){
        return Width;
       }
}
}
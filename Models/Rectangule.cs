using Abstraction.Interfaces;

namespace Abstraction.Models
{
    public class Rectangule:IHight
    {
       public int Width {get;set;}
       public int Hight {get;set;}
        public int GetArea()
        {
            
        return Width *Hight ;
        }
    }
}
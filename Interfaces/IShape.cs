using System;
using System.Collections.Generic;
using System.Linq;
namespace Abstraction.Interfaces
{
    public interface IShape
    {
        int Width {get;set;}
        int GetArea();
    }
}
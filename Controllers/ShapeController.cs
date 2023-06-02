using Abstraction.Interfaces;
using Abstraction.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Abstraction.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ShapeController : ControllerBase
{
  [HttpGet(Name ="GetShape")]
  public  IEnumerable<int>Get()
  {
    List<IShape> shapes =new List<IShape>();
    IShape square = new Square() {Width=10};
    IShape rectangule = new Rectangule() 
    {
        Width=10,
        Hight=20
    };
    
    shapes.Add(square);
    shapes.Add(rectangule);


    var result = new List<int>();
        foreach (IShape shape in shapes)
        {
             result.Add(shape.GetArea());
        }

          return result; 
}

}

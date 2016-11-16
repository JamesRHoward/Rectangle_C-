// This loads the Nancy framework for this project
using Nancy;
// I have no idea what this does, look it up
using System.Collections.Generic;
// namespace "Rectangle" can be any name you wish to use, name it something related to your project
namespace RectangleChecker
{
  // class HomeModule references the name of the file, then tells it to use NancyModule ?????? Not 100% sure
  public class HomeModule : NancyModule
  {
    // homeModule is a method that handles routing of the files
    public HomeModule()
    {
      // this tells the (home page aka root, or "/")  to return the file from the View folder called "rectable_form.cshtml"
      Get["/"] = _ => {
        return View["rectangle_form.cshtml"];
      };

      Get["/rectangle_result"] = _ => {
        // dictionary is built into c#, Shapes is the actual variable name.
        Dictionary<string, object> Shapes = new Dictionary<string, object>();
        Rectangle myRectangle = new Rectangle(Request.Query["side-length"], Request.Query["side-width"]);
        Shapes.Add("ResultingRectangle", myRectangle);

        // this takes the two sides in recangle and runs a method to check if they are equal
        if (myRectangle.IsSquare())
        {
        // if they are equaly, create a new instance of Cube object called myCube and pass in the information from myRectangle
          Cube myCube = new Cube(myRectangle);
        // the dictionary "Shpaes" has the method add() called on it, passing in a string 'ResultingCube', and the object myCube
        // which contains the information from myRectangle;
          Shapes.Add("ResultingCube", myCube);
        }
        // this returens rectangle_result from the view folder, along with the dictionary called shapes.
        return View["rectangle_result.cshtml", Shapes];
      };

    }
  }
}

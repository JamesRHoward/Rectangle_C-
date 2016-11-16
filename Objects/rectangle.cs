// This holds all of the classes or any code related to your project
namespace RectangleChecker
{

  // This defines a class (aka "holder") for all the code related to Rectangle
  public class Rectangle
  {
  // This declares two variable names, which are currently empty, that will hold our rectangle values
    private int _length;
    private int _width;

    // This creates a method that allows you to pass two rectangle lengths into the two variable names that we just set.  It defines what a Rectanble is.
    public Rectangle(int sideLength, int sideWidth)
    {
      _length = sideLength;
      _width = sideWidth;
    }
      // This creates a method that will go and GET the PRIVATE _length variable and return it as PUBLIC.
    public int GetLength()
    {
      return _length;
    }
    // This creates a method that passes in the newLength from the form input and sets our original _length variable to its value
    public void SetLength(int newLength)
    {
      _length = newLength;
    }
      // This creates a method that will go and GET the PRIVATE _width variable and return it as PUBLIC.
    public int GetWidth()
    {
      return _width;
    }
    // This creates a method that passes in the newWidth from the form input and then sets our original _width variable to its value
    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }

    // this creates a method that takes the two values of length and width and then multiplies them together to find the area;
    public int GetArea()
    {
      return _length * _width;
    }

    // this creates a methed that checks to see if the rectangle is square.  if lenght is equal to width, return true.  else, return false.
    // the bool is short for boolean, and you need to use bool because it is holding a true or false value, not a string or an integer.
    public bool IsSquare()
    {
      // c# only uses two == to check if something is equal to
      if (_length == _width)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}

// notice that we continue to use the same namespace, despite having multiple files that do different things.
// these files could be all combined into one file, but it is easier to separate them.
namespace RectangleChecker
{
  // this will define a new class called Cube that contains all of our methods and variables.
  public class Cube
  {
    // this defines a variable / it is set to private / it is an instance of the object Rectangle / it is called _face /
    private Rectangle _face;
    // this sets an instance of cube, which is a placeholder for the information that will come from Rectangle. it also sets it to public.
    public Cube (Rectangle side)
    {
      _face = side;
    }

    // this creates a method that will get the values of the rectangle and do math to find volume.
    public int GetVolume()
    {
      // this defines a variable called length, which uses the _face placeholder and calls the method GetLength() on it
      // to retrieve information from Rectangle
      int length = _face.GetLength();
      // this does the math to figure out the volume based on the length
      return length * length * length;
    }

    // this creates a method that gets the calls .GetArea() method on _face, which is an instance of object rectangle
    //
    public int GetSurfaceArea()
    {
      return _face.GetArea() * 6;
    }
  }
}

using System;

class MainClass 
{
  class Box
  {
    public int Height {get; set;}
    public int Width {get; set;}

    public Box (int h, int w)
    {
      Height = h;
      Width = w;
    }

    public static Box operator+(Box a, Box b)
    {
      int h = a.Height + b.Height;
      int w = a.Width + b. Width;
      Box res = new Box(h, w);
      return res;
    }
  }


  public static void Main (string[] args) 
  {
    Box b1 = new Box(26, 6);
    Box b2 = new Box(30, 86);
    Box b3 = b1 + b2;

    Console.WriteLine(b3.Height);
    Console.WriteLine(b3.Width);
  }
}

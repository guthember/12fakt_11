using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukturak
{
  class Program
  {
    struct Pont
    {
      public int x;
      public int y;

      public void Kiir()
      {
        Console.WriteLine("x: {0}, y: {1}",x,y);
      }
    }

    static void Main(string[] args)
    {
      Pont a = new Pont();
      Pont b = new Pont();

      a.x = 0;
      a.y = 0;

      b.x = 3;
      b.y = 4;

      //Console.WriteLine("a: {0} {1}", a.x, a.y);
      //Console.WriteLine("b: {0} {1}", b.x, b.y);
      Console.WriteLine("a pont");
      a.Kiir();
      Console.WriteLine("b pont");
      b.Kiir();

      double x = Math.Abs(a.x - b.x);
      double y = Math.Abs(a.y - b.y);

      double tavolsag = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));

      Console.WriteLine("A két pont közti távolság: {0}",tavolsag);

      Console.ReadKey();
    }
  }
}

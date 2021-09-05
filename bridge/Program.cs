using System;

namespace bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Artist artist = new Artist();

            Abstraction abstraction;

            abstraction = new Abstraction(new Circle());
            artist.DoSmth(abstraction);

            abstraction = new Abstraction(new Square());
            artist.DoSmth(abstraction);
        }
    }
}

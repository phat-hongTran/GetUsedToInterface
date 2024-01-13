using System;

namespace GetUsedToInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Height = 76, Name = "Jimmy" };
            tallGuy.TalkAboutYourself();
        }
    }
}

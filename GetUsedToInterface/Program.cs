using System;

namespace GetUsedToInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //TallGuy tallGuy = new TallGuy() { Height = 76, Name = "Jimmy" };
            //tallGuy.TalkAboutYourself();
            //Console.WriteLine($"The tall guy has {tallGuy.FunnyThingIHave}");
            //tallGuy.Honk();

            IClown.CarCapacity = 18;
            Console.WriteLine(IClown.ClownCarDescription());

            IClown fingersTheClown = new ScaryScary("big red nose", 14);
            fingersTheClown.Honk();
            if (fingersTheClown is IScaryClown iScaryClownReference)
            {
                iScaryClownReference.ScareLittleChildren();
            }
        }
    }
}

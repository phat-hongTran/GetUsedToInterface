namespace GetUsedToInterface
{
    public class TallGuy
    {
        public string Name;
        public int Height;

        public void TalkAboutYourself()
        {
            Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");
        }
    }
}
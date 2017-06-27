using System;

namespace DecoratorPattern
{
    class DecoratorPattern
    {
        static void Main(string[] args)
        {
            Item item = new BasicItem();
            ShowInfo(item);

            item = new PolkaDotItem(item);
            ShowInfo(item);

            item = new ImprovingItem(item);
            ShowInfo(item);

            item = new ImprovingItem(new BasicItem());
            ShowInfo(item);
        }

        private static void ShowInfo(Item item)
        {
            Console.WriteLine("Attributes of " + item.GetType() + ": <" + item.GetAttributes() + ">");
        }
    }
}

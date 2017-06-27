namespace DecoratorPattern
{
    public abstract class ItemDecorator : Item
    {
        protected Item _decoratedItem;

        public ItemDecorator(Item item)
        {
            this._decoratedItem = item;
        }

        public abstract string GetAttributes();

    }
}

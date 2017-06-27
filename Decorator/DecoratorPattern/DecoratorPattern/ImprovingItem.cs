using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class ImprovingItem : ItemDecorator

    {
        public ImprovingItem(Item item) : base(item)
        {
        }

        public override string GetAttributes()
        {
            return _decoratedItem.GetAttributes() + "Improving";
        }
    }
}

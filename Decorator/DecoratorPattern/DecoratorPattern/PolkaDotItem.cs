using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class PolkaDotItem : ItemDecorator
    {
        public PolkaDotItem(Item item) : base(item)
        {
        }

        public override string GetAttributes()
        {
            return this._decoratedItem.GetAttributes() + "PolkaDot";
        }
    }
}

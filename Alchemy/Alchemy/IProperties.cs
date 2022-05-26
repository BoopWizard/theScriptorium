using System;
using System.Collections.Generic;
using System.Text;

namespace Alchemy
{
    enum Element
    {
        Fire,
        Water,
        Earth,
        Air,
        Order,
        Chaos
    }
    interface IProperties
    {
        public bool isSolid
        {
            get;
            set;
        }
        public Element element
        {
            get;
            set;
        }
    }
}

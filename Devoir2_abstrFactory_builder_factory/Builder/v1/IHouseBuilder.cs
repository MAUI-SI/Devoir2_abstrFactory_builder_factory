using Data.v1.Building;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.v1
{
    internal interface IHouseBuilder: IBuilder
    {
        public House getHouse();
    }
}

using Data.v1.Building;
using Data.v1.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.v1
{
    internal interface IAbstractFactory
    {
        public House makeHouse();
        public Duplex makeDuplex();
    }
}

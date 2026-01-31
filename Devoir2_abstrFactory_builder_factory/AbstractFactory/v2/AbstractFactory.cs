using Data.v2.Product.Basement;
using Data.v2.Product.Interior;
using Data.v2.Product.Roof;
using Data.v2.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.v2
{
    internal interface IAbstractFactory
    {
        public IBasement makeBasement();
        public IStructure makeStructure();
        public IInterior makeInterior();
        public IRoof makeRoof();
    }
}

using Data.v2.Product.Basement;
using Data.v2.Product.Interior;
using Data.v2.Product.Roof;
using Data.v2.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.v2
{
    internal class PersianFactory: IAbstractFactory
    {
        public IBasement makeBasement()
        {
            return new PersianBasement();
        }
        public IStructure makeStructure()
        {
            return new PersianStructure();
        }

        public IInterior makeInterior()
        {
            return new PersianInterior();
        }

        public IRoof makeRoof()
        {
            return new PersianRoof();
        }
    }
}

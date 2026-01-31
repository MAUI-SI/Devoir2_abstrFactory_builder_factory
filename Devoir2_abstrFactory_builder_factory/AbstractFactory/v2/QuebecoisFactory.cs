using AbstractFactory.v2;
using Data.v2.Product.Basement;
using Data.v2.Product.Interior;
using Data.v2.Product.Roof;
using Data.v2.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.v2
{
    internal class QuebecoisFactory : IAbstractFactory
    {
        public IBasement makeBasement()
        {
            return new QuebecoisBasement();
        }
        public IStructure makeStructure()
        {
            return new QuebecoisStructure();
        }

        public IInterior makeInterior()
        {
            return new QuebecoisInterior();
        }

        public IRoof makeRoof()
        {
            return new QuebecoisRoof();
        }


    }
}

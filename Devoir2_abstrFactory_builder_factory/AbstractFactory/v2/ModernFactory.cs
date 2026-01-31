using Data.v2.Product.Basement;
using Data.v2.Product.Interior;
using Data.v2.Product.Roof;
using Data.v2.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.v2
{
    internal class ModernFactory : IAbstractFactory
    {
        public IBasement makeBasement()
        {
            return new ModernBasement();
        }

        public IInterior makeInterior()
        {
            return new ModernInterior();
        }

        public IRoof makeRoof()
        {
            return new ModernRoof();
        }

        public IStructure makeStructure()
        {
            return new ModernStructure();
        }
    }
}

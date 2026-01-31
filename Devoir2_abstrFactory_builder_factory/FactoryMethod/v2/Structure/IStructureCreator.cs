using Data.v2.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.v2.Structure
{
    internal interface IStructureCreator
    {
        IStructure FactoryMethod();
    }
}

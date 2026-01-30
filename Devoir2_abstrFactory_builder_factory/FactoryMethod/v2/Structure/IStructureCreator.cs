using Devoir2_abstrFactory_builder_factory.Data.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir2_abstrFactory_builder_factory.FactoryMethod.v2.Structure
{
    internal interface IStructureCreator
    {
        IStructure FactoryMethod();
    }
}

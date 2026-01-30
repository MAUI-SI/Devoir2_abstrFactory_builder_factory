using Devoir2_abstrFactory_builder_factory.Data.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir2_abstrFactory_builder_factory.FactoryMethod
{
    internal interface IStructureCreator
    {
        IStructure FactoryMethod();
    }
}

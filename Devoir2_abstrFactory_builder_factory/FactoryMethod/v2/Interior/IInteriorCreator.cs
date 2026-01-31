using Data.v2.Product.Interior;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.v2.Interior
{
    internal interface IInteriorCreator
    {
        IInterior FactoryMethod();
    }
}

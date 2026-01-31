using Data.v2.Product.Roof;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.v2.Roof
{
    internal interface IRoofCreator<T>
    {
        IRoof FactoryMethod();
    }
}

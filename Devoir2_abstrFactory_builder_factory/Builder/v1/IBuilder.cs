using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.v1
{
    internal interface IBuilder
    {
        public IBuilder buildBasement();
        public IBuilder buildStructure();
        public IBuilder buildInterior();
        public IBuilder buildRoof();
    }
}

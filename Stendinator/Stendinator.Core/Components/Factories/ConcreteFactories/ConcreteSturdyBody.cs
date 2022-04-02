﻿using Stendinator.Core.Components.Heads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stendinator.Core.Components.Body;

namespace Stendinator.Core.Components.Factories.ConcreteFactories
{
    internal class ConcreteSturdyBody : ComponentFactory
    {
        public override Component Create()
        {
            return new SturdyBody();
        }
    }
}
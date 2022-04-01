﻿using Stendinator.Core.Components.Arms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stendinator.Core.Components.Factories.ConcreteFactories
{
    internal class ConcreteFlameThrowerArm : ComponentFactory
    {
        public override Component Create()
        {
            return new FlameThrowerArm();
        }
    }
}

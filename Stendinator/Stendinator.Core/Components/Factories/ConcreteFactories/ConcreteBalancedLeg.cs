﻿using Stendinator.Core.Components.Legs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stendinator.Core.Components.Factories.ConcreteFactories
{
    internal class ConcreteBalancedLeg : ComponentFactory
    {
        public override Component Create()
        {
            return new BalancedLeg();
        }
    }
}
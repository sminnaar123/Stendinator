﻿using Stendinator.Core.Components.Heads;
using Stendinator.Core.Components.Legs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stendinator.Core.Components.Factories.AbstractComponentFactories
{
    internal class BalancedComponentFactory : IAbstractComponentFactory
    {
        public Component CreateLeg()
        {
            return new BalancedLeg();
        }

        public Component CreateHead()
        {
            return new BalancedHead();
        }

        public Component CreateBody()
        {
            return new BalancedLeg();
        }
    }
}
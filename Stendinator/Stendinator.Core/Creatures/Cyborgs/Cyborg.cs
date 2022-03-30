﻿using Stendinator.Core.Components;
using Stendinator.Core.Components.Targets;

namespace Stendinator.Core.Creatures.Cyborgs
{
    internal class Cyborg : Creature
    {
        private Component _leftArm;
        private Component _rightArm;
        private Component _torso;
        private Component _head;
        private Component _leftLeg;
        private Component _rightLeg;

        public Cyborg()
        {
            _leftArm = null;
            _rightArm = null;
            _torso = null;
            _head = null;
            _leftLeg = null;
            _rightLeg = null;
        }

        public void SetLeftArm(Component component)
        {
            SetComponent(ref _leftArm, component);
        }

        public void SetRightArm(Component component)
        {
            SetComponent(ref _rightArm, component);
        }

        public void AddTorso(Component component)
        {
            SetComponent(ref _torso, component);
        }

        public void AddHead(Component component)
        {
            SetComponent(ref _head, component);
        }

        public void AddRightLeg(Component component)
        {
            SetComponent(ref _rightLeg, component);
        }

        public void AddLeftLeg(Component component)
        {
            SetComponent(ref _leftLeg, component);
        }

        private void SetComponent(ref Component oldComponent, Component newComponent)
        {
            if (oldComponent != null) RemoveComponent(oldComponent);
            AddComponent(newComponent);
            oldComponent = newComponent;
        }

        protected override void HandleActivatedComponent(ActiveComponent activeComponent, Target args)
        {
            //Handle components used on Target entity
        }
    }
}
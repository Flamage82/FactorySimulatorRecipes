using System.Collections.Generic;

namespace FactorySimulatorRecipes
{
    public abstract class Component
    {
        public abstract ComponentType Type { get; }

        public Dictionary<Component, double> Components { get; } = new Dictionary<Component, double>();
    }
}

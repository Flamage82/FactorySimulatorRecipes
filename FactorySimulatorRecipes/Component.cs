using System.Collections.Generic;

namespace FactorySimulatorRecipes
{
    public class Component
    {
        public Dictionary<Component, double> Components { get; } = new Dictionary<Component, double>();
    }
}

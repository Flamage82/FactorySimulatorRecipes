namespace FactorySimulatorRecipes.Components
{
    public class TinWire : Component
    {
        public override ComponentType Type { get; } = ComponentType.TinWire;

        public TinWire()
        {
            Components.Add(new TinIngot(), 0.5);
        }
    }
}

namespace FactorySimulatorRecipes.Components
{
    public class HeatingElement : Component
    {
        public override ComponentType Type { get; } = ComponentType.HeatingElement;

        public HeatingElement()
        {
            Components.Add(new Circuit1(), 1);
            Components.Add(new IronPlate(), 1);
            Components.Add(new TinWire(), 2);
        }
    }
}

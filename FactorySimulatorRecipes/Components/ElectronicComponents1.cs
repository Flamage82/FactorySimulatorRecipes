namespace FactorySimulatorRecipes.Components
{
    public class ElectronicComponents1 : Component
    {
        public override ComponentType Type { get; } = ComponentType.ElectronicComponents1;

        public ElectronicComponents1()
        {
            Components.Add(new TinWire(), 4);
        }
    }
}

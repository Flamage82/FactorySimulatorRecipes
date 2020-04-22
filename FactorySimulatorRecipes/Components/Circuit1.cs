namespace FactorySimulatorRecipes.Components
{
    public class Circuit1 : Component
    {
        public override ComponentType Type { get; } = ComponentType.Circuit1;

        public Circuit1()
        {
            Components.Add(new ElectronicComponents1(), 2);
            Components.Add(new IronPlate(), 1);
        }
    }
}

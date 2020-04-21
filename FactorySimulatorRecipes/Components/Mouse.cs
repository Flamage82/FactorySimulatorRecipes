namespace FactorySimulatorRecipes.Components
{
    public class Mouse : Component
    {
        public Mouse()
        {
            Components.Add(new Circuit1(), 1);
            Components.Add(new ElectronicComponents1(), 2);
            Components.Add(new TinWire(), 2);
            Components.Add(new Plastic(), 2);
        }
    }
}

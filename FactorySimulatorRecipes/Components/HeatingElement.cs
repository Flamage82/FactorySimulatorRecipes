namespace FactorySimulatorRecipes.Components
{
    public class HeatingElement : Component
    {
        public HeatingElement()
        {
            Components.Add(new Circuit1(), 1);
            Components.Add(new IronPlate(), 1);
            Components.Add(new TinWire(), 2);
        }
    }
}

namespace FactorySimulatorRecipes.Components
{
    public class TinWire : Component
    {
        public TinWire()
        {
            Components.Add(new TinIngot(), 0.5);
        }
    }
}

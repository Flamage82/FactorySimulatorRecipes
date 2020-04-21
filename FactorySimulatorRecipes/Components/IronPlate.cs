namespace FactorySimulatorRecipes.Components
{
    public class IronPlate : Component
    {
        public IronPlate()
        {
            Components.Add(new IronIngot(), 1);
        }
    }
}

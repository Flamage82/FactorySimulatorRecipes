namespace FactorySimulatorRecipes.Components
{
    public class IronPlate : Component
    {
        public override ComponentType Type { get; } = ComponentType.IronPlate;

        public IronPlate()
        {
            Components.Add(new IronIngot(), 1);
        }
    }
}

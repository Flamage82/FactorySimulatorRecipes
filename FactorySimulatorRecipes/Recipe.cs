using System.Collections.Generic;
using System.Linq;

namespace FactorySimulatorRecipes
{
    public class Recipe
    {
        private readonly Dictionary<Component, double> outputs;

        public Recipe(Dictionary<Component, double> outputs)
        {
            this.outputs = outputs;
        }

        public Dictionary<string, double> BaseIngredients => GetBaseIngredients(outputs, 1);

        private  Dictionary<string, double> GetBaseIngredients(Dictionary<Component, double> components, double quantity)
        {
            return components
                .SelectMany(pair => pair.Key.Components.Count == 0 ? new KeyValuePair<string, double>(pair.Key.GetType().Name, pair.Value * quantity).Yield() : GetBaseIngredients(pair.Key.Components, pair.Value * quantity))
                .GroupBy(pair => pair.Key)
                .ToDictionary(pairs => pairs.Key, pairs => pairs.Sum(pair => pair.Value));
        }
    }
}

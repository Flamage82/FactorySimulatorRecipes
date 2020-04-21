using System.Collections.Generic;

namespace FactorySimulatorRecipes
{
    public static class ExtensionMethods
    {
        public static IEnumerable<T> Yield<T>(this T obj)
        {
            yield return obj;
        }
    }
}

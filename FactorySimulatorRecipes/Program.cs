using System;
using System.Collections.Generic;
using System.Linq;
using FactorySimulatorRecipes.Components;

namespace FactorySimulatorRecipes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // var outputs = new Dictionary<Component, int>
            // {
            //     {
            //         new HeatingElement(), 10
            //     }
            // };
            //
            // Console.WriteLine(RenderRecipe(new Recipe(outputs).BaseIngredients));

            var outputs = new Dictionary<Component, double>
            {
                {
                    new Mouse(), 10
                }
            };

            Console.WriteLine(RenderRecipe(new Recipe(outputs).BaseIngredients));
        }

        private static string RenderRecipe(Dictionary<string, double> recipe)
        {
            return string.Join(", ", recipe.Select(pair => $"{pair.Value} {pair.Key}"));
        }
    }
}

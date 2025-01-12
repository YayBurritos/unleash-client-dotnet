using System.Collections.Generic;
using Unleash.Variants;

namespace Unleash.Internal
{
    public class ActivationStrategy
    {
        public string Name { get; }
        public Dictionary<string, string> Parameters { get; }
        public List<Constraint> Constraints { get; }
        public List<string> Segments { get; }
        public List<VariantDefinition> Variants { get; }

        public ActivationStrategy(string name, Dictionary<string, string> parameters, List<Constraint> constraints = null, List<string> segments = null, List<VariantDefinition> variants = null)
        {
            Name = name;
            Parameters = parameters ?? new Dictionary<string, string>();
            Constraints = constraints ?? new List<Constraint>();
            Segments = segments ?? new List<string>();
            Variants = variants ?? new List<VariantDefinition>();
        }
    }
}
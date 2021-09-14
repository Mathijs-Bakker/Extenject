using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.Build;

namespace Zenject.Internal
{
    public sealed class TestBuildAssemblyFilter : IFilterBuildAssemblies
    {
        private readonly IReadOnlyList<string> ExcludedAssemblies = new List<string>
        {
            "Zenject-TestFramework"
        };

        public int callbackOrder { get; }

        public string[] OnFilterAssemblies(BuildOptions buildOptions, string[] assemblies)
        {
            if (buildOptions.HasFlag(BuildOptions.IncludeTestAssemblies))
            {
                return assemblies;
            }
            return assemblies.Where(x => ValidateName(x)).ToArray();
        }

        private bool ValidateName(string assemblyName)
        {
            for (int i = 0; i < ExcludedAssemblies.Count; ++i)
            {
                string target = ExcludedAssemblies[i];

                if (assemblyName.Contains(target))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

using System.Collections.Generic;
using System.Reflection;

namespace EventHorizon.Blazor.MicroFrontend.Shell.State
{
    public class ShellState
    {
        public IEnumerable<Assembly> FeatureAssemblyList { get; }

        public ShellState(
            IEnumerable<Assembly> featureAssemblyList
        )
        {
            FeatureAssemblyList = featureAssemblyList;
        }
    }
}
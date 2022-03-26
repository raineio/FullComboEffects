using System.Runtime.CompilerServices;
using IPA.Config.Stores;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace FullComboEffects.Configuration
{
    public class PluginConfig
    {
        internal class Config
        {
            public virtual bool Enabled { get; set; }
            public virtual bool UseColors { get; set; }
            public virtual bool MakeTextSayFC { get; set; }
            public virtual bool FireworksToggle { get; set; }
        }
    }
}